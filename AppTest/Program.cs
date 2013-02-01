using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataRepositories;
using System.Data.Entity;
using DataLayer.Model;
namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ExpenseContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CommonContext>());

            IDataRepositories<Account> AccountRepo = new AccountsRepositories();
            AccountRepo.AddOrUpdate(new Account { Id="100010", Name="test account", CategoryId="1000", CustomerId="11", Balance=0});
            AccountRepo.Save();

            foreach (Account a in AccountRepo.All)
            {
                Console.WriteLine("{0} - {1}",a.Id, a.Name);
            }
        }
    }
}
