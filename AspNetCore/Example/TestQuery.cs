using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace Example
{
    public class TestQuery : ObjectGraphType<object>
    {
        public TestQuery(PersonDatas data)
        {
             Name = "Query";

            FieldAsync<PersonType>(
                "person",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the human" }
                ),
                resolve: async context => await data.GetPersonByIdAsync(context.GetArgument<string>("id"))
            );
        }
    }
}
