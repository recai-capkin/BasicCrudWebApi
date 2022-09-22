using Microsoft.EntityFrameworkCore;

namespace Crud_UI.Models.Context
{
    public class BaseContext:DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
