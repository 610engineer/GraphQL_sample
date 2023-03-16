using Microsoft.EntityFrameworkCore;

namespace HotChocolateSample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //DATABASEとやり取りするためのもの
        public DbSet<Person> Persons { get; set; }
    }
}
