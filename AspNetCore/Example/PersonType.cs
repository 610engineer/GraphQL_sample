using GraphQL.Types;

namespace Example
{
    public class PersonType : ObjectGraphType<Person>
    {
        //Personから取得できるプロパティを設定
        public PersonType(PersonDatas data)
        {
            Name = "Person";

            Field(h => h.Id).Description("The id of the Person.");
            Field(h => h.Name, nullable: true).Description("The name of the Person.");
            Field(h => h.Location, nullable: true).Description("The name of the location.");
        }
    }
}
