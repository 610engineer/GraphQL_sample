using HotChocolateSample.Data;
using Microsoft.EntityFrameworkCore;

namespace HotChocolateSample
{
    public class TestQuery
    {
        //DBに登録されているPerson全取得
        public async Task<List<Person>> GetPersons([Service] ApplicationDbContext context)
        {
            return await context.Persons.ToListAsync();
        }
        //IDで指定されたPersonを取得

        public async Task<Person> GetPersonById([Service] ApplicationDbContext context, int id)
        {
            return await context.Persons.FirstOrDefaultAsync(x => x.Id == id);
        }

        //名前検索
        public async Task<Person> GetPersonByName([Service] ApplicationDbContext context, string name)
        {
            return await context.Persons.FirstOrDefaultAsync(x => x.Name == name);
        }



    }
}
