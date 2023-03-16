using HotChocolateSample.Data;
using Microsoft.EntityFrameworkCore;

namespace HotChocolateSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlite("Data Source=testGraphQL.db"));

            services
                .AddGraphQLServer()
                //Queryを定義
                .AddQueryType<TestQuery>()
                //Mutationを定義
                .AddMutationType<TestMutation>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //pathをxxx/graphqlで指定
                endpoints.MapGraphQL("/graphql");
            });
            
        }
    }
}
