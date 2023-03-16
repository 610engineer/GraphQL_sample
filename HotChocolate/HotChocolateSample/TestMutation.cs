using HotChocolateSample.Data;

namespace HotChocolateSample
{
    public class TestMutation
    {
        //Person登録
        public async Task<Person> AddPersonAsync(
            [Service] ApplicationDbContext context,
            string name, string location)
        {
            var person = new Person
            {
                Name = name,
                Location = location
            };

            //DBへの追加
            context.Persons.Add(person);

            //DBへの変更を保存
            await context.SaveChangesAsync();

            return person;
        }
    }
}
