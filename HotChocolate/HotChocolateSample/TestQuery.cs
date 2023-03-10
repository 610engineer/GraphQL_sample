using HotChocolateSample.Data;

namespace HotChocolateSample
{
    public class TestQuery
    {
        public IQueryable<Person> GetPersons([Service] ApplicationDbContext context) =>
            context.Persons;
    }
}
