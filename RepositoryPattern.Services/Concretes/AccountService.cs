using Data.Abstracts;
using Domain.Entities;
using RepositoryPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Services.Concretes
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Account> _accountRepository;
        public AccountService(IRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account GetAccount(Guid id)
        {
            return _accountRepository.GetById(id);
        }

        public IEnumerable<Account> GetAccountList()
        {
            return _accountRepository.GetAll().ToList();
        }

        public void PostAccount(Account account)
        {
            _accountRepository.Post(account);
        }

        public void UpdateAccount(Account account)
        {
            _accountRepository.Update(account);
        }
        public void DeleteAccount(Account account)
        {
            _accountRepository.Delete(account);
        }


    }
}
