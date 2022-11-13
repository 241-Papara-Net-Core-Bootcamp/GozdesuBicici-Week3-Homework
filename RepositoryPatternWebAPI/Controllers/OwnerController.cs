using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Services.Abstracts;
using System;
using System.Linq.Expressions;

namespace RepositoryPattern.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpGet("Owners")]
        public IActionResult GetAll()
        {
            var result = _ownerService.GetOwnerList();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _ownerService.GetOwner(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Post(Owner owner)
        {            
            _ownerService.PostOwner(owner);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Owner owner)
        {
            _ownerService.UpdateOWner(owner);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(Owner owner)
        {
            _ownerService.DeleteOwner(owner);
            return Ok();
        }
        [HttpGet]
        public IActionResult Find(Expression<Func<Owner, bool>> expression)
        {
            _ownerService.FindOwner(expression);
            return Ok();
        }

    }
}
