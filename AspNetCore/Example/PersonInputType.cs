using GraphQL.Types;

namespace Example
{
    public class PersonInputType : InputObjectGraphType<Person>
    {
        public PersonInputType()
        {
            Name = "PersonInput";
            Field(x => x.Name);
            Field(x => x.Location, nullable: true);
        }
    }
}
