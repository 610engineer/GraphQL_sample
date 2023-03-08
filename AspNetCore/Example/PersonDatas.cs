using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    public class PersonDatas
    {
        private readonly List<Person> _person = new List<Person>();

        //実際のDBの実体
        public PersonDatas()
        {
            _person.Add(new Person{
                Id = "1",
                Name = "aaa",
                Location = "Tokyo"
            });
            _person.Add(new Person
            {
                Id = "2",
                Name = "bbb",
                Location = "Osaka"
            });
            _person.Add(new Person
            {
                Id = "3",
                Name = "ccc",
                Location = "Aichi"
            });
        }

        //DBからIDをキーにして情報をGETするためのメソッド
        public Task<Person> GetPersonByIdAsync(string id)
        {
            return Task.FromResult(_person.FirstOrDefault(h => h.Id == id));
        }

        public Task<Person> GetPersonByNameAsync(string name)
        {
            return Task.FromResult(_person.FirstOrDefault(h => h.Name == name));
        }

        public Person AddPerson(Person person)
        {
            person.Id = Guid.NewGuid().ToString();
            _person.Add(person);
            return person;
        }
    }
}
