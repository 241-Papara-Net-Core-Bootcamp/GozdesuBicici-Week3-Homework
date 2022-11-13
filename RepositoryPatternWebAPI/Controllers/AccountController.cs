using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Services.Abstracts;
using System;

namespace RepositoryPattern.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet("Accounts")]
        public IActionResult GetAll()
        {
            var result = _accountService.GetAccountList();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _accountService.GetAccount(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Post(Account account)
        {
            _accountService.PostAccount(account);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Account account)
        {
            _accountService.UpdateAccount(account);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(Account account)
        {
            _accountService.DeleteAccount(account);
            return Ok();
        }
    }
}
