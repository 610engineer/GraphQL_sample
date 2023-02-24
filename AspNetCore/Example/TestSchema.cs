using System;
using GraphQL.Instrumentation;
using GraphQL.Types;


namespace Example
{
    public class TestSchema : Schema
    {
        public TestSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = (TestQuery)provider.GetService(typeof(TestQuery)) ?? throw new InvalidOperationException();

            FieldMiddleware.Use(new InstrumentFieldsMiddleware());
        }
    }
}
