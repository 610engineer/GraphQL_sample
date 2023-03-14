using HotChocolateSample.Data;
using Microsoft.EntityFrameworkCore;

namespace HotChocolateSample
{
    public class TestQuery
    {
        public async Task<List<Person>> GetPersons([Service] ApplicationDbContext context)
        {
            return await context.Persons.ToListAsync();
        }

        public async Task<Person> GetPersonById([Service] ApplicationDbContext context, int id)
        {
            return await context.Persons.FirstOrDefaultAsync(x => x.Id == id);
        }
            


    }
}
