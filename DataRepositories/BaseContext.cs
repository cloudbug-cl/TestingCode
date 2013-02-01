using System.Data.Entity;

namespace DataLayer.Model
{
    public class BaseContext<T> : DbContext where T : DbContext
    {
        //static BaseContext()
        //{
        //    Database.SetInitializer<T>(null);
        //}
        protected BaseContext()
            : base("name=TestDB")
        {
        }
    }
}