using System.Data.Entity;

namespace DataLayer.Model
{
    public class ExpenseContext : BaseContext<ExpenseContext>
    {
        public ExpenseContext() : base() { }
        public DbSet<Account> Accounts { get;set;}
        public DbSet<Expense> Expenses {get;set;}
    }
}