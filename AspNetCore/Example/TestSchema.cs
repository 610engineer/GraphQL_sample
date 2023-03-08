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
            //"Query"で取得できる情報をTestQueryの内容に指定
            Query = (TestQuery)provider.GetService(typeof(TestQuery)) ?? throw new InvalidOperationException();
            Mutation = (TestMutation)provider.GetService(typeof(TestMutation)) ?? throw new InvalidOperationException();

            FieldMiddleware.Use(new InstrumentFieldsMiddleware());
        }
    }
}
