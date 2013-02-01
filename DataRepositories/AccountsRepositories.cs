using System;
using System.Linq;
using DataLayer.Model;
using System.Data;

namespace DataRepositories
{
    public class AccountsRepositories : 
        IDataRepositories<Account>
    {
        ExpenseContext context = new ExpenseContext();

        public IQueryable<Account> All
        {
            get
            {
                return context.Accounts;
            }
        }
        public Account Find(string id)
        {
            try
            {
                return context.Accounts.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public void AddOrUpdate(Account obj)
        {
            try
            {
                var acct = context.Accounts.Find(obj.Id);
                if (acct == null)
                {
                    context.Entry(obj).State = EntityState.Added;
                }
                else
                {
                    context.Entry(obj).State = EntityState.Modified;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Delete(string id)
        {
            try
            {
                var obj = context.Accounts.Find(id);
                context.Accounts.Remove(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
