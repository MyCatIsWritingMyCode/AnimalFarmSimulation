using Microsoft.EntityFrameworkCore;
using Refresh1_24.Data;
using Refresh1_24.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Repository
{
    internal class AccountRepository: IAccountRepository 
    {
        private readonly DataContext _context;
        private readonly DbSet<Account> _dbSet;
        public AccountRepository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<Account>();
        }
        
        public ICollection<Account> GetAllAccounts()
        {
            return _dbSet.ToList();
        }

        public Account GetAccountById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(Account account)
        {
            _dbSet.Add(account);
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetAccountById(id));
        }
        public void Update(Account account)
        {
            _context.Entry(account).State = EntityState.Modified;
        }
    }
}
