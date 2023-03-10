namespace HotChocolateSample
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        public string Id { get; set; }
        public string Pref { get; set; }
        public string City  { get; set; }
    }
}
