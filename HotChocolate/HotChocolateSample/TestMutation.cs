using HotChocolateSample.Data;

namespace HotChocolateSample
{
    public class TestMutation
    {
        public async Task<Person> AddPersonAsync(
            [Service] ApplicationDbContext context,
            string name, string location)
        {
            var person = new Person
            {
                Name = name,
                Location = location
            };

            context.Persons.Add(person);

            await context.SaveChangesAsync();

            return person;
        }
    }
}
