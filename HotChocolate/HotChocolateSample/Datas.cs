namespace HotChocolateSample
{
    public class Datas
    {
        private readonly List<Person> _person = new List<Person>();

        public Datas()
        {
            //DBの実体
            _person.Add(new Person
            {
                Id = "1",
                Name = "aaa",
                Location = new Location
                {
                    Pref = "Tokyo",
                    City = "Shinagawa"
                }

            });
            _person.Add(new Person
            {
                Id = "2",
                Name = "bbb",
                Location = new Location
                {
                    Pref = "Osaka",
                    City = "Nanba"
                }
            });
            _person.Add(new Person
            {
                Id = "3",
                Name = "ccc",
                Location = new Location
                {
                    Pref = "Aichi",
                    City = "Nagoya"
                }
            });
        }
    }
}
