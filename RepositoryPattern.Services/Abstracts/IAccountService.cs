using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Services.Abstracts
{
    public interface IAccountService
    {       
        public IEnumerable<Account> GetAccountList();
        public Account GetAccount(Guid id);
        public void PostAccount(Account account);
        public void UpdateAccount(Account account);
        public void DeleteAccount(Account account);
    }
}
