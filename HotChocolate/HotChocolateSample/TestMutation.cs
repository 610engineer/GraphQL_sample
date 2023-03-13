using HotChocolateSample.Data;

namespace HotChocolateSample
{
    public class TestMutation
    {
        public async Task<Person> AddPersonAsync(
            [Service] ApplicationDbContext context,
            string name)
        {
            var person = new Person
            {
                Name = name,
                //Location = input.Location
            };

            context.Persons.Add(person);

            await context.SaveChangesAsync();

            return person;
        }
    }
}
