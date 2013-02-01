using System.Data.Entity;

namespace DataLayer.Model
{
    public class CommonContext : BaseContext<CommonContext>
    {
        public CommonContext() : base() { }
        public DbSet<Category> Categories {get; set;}
        public DbSet<Customer> Customers {get; set;}
    }
}

