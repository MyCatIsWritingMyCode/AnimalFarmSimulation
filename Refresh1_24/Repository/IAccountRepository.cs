using Refresh1_24.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Repository
{
    internal interface IAccountRepository
    {
        Account GetAccountById(int id);
        ICollection<Account> GetAllAccounts();
        void Add(Account account);
        void Update(Account account);
        void Delete(int id);

    }
}
