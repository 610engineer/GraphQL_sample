namespace graphql_sample
{
    public class Query
    {
        public book GetBook() =>
            new book
            {
                title = "GRAPHQL",
                Author = new Author
                {
                    Name = "Sample"
                }
            };
    }
}
