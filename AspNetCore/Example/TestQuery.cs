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
            //"Query"でGETできる情報を設定
            Name = "Query";

            //"person"を指定してIDをキーにDBにクエリを投げる
            FieldAsync<PersonType>(
                "person",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the person" }
                ),
                resolve: async context => await data.GetPersonByIdAsync(context.GetArgument<string>("id"))
            );
        }
    }
}
