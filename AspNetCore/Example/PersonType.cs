using GraphQL.Types;

namespace Example
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType(PersonDatas data)
        {
            Name = "Person";

            Field(h => h.Id).Description("The id of the human.");
            Field(h => h.Name, nullable: true).Description("The name of the human.");
            Field(h => h.Location, nullable: true).Description("The name of the location.");
        }
    }
}
