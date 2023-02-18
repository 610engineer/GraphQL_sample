namespace graphql_sample
{
    public class book
    {
        public string title { get; set; }
        public Author Author { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }
}
