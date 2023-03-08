using GraphQL;
using GraphQL.Types;

namespace Example
{
    public class TestMutation: ObjectGraphType
    {
        public TestMutation(PersonDatas data)
        {
            Name = "Mutation";
            Field<PersonType>(
           "createPerson",
           arguments: new QueryArguments(
               new QueryArgument<NonNullGraphType<PersonInputType>> { Name = "person" }
           ),
           resolve: context =>
           {
               var person = context.GetArgument<Person>("person");
               return data.AddPerson(person);
           });
        }
    }
}
