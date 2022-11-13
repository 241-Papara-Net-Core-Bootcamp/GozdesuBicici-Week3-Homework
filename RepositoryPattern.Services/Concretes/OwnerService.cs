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
    public class OwnerService : IOwnerService
    {
        private readonly IRepository<Owner> _ownerRepository;
        public OwnerService(IRepository<Owner> ownerRepository)
        {
            _ownerRepository= ownerRepository;
        }

       
        public IQueryable<Owner> FindOwner(Expression<Func<Owner, bool>> expression)
        {
            // Adı Gözdesu olanları bul ve listele.
            return (IQueryable<Owner>)_ownerRepository.Find(x => x.Name.Equals("Gözdesu")).ToList();
        }

        public Owner GetOwner(Guid id)
        {
            return _ownerRepository.GetById(id);
        }

        public IEnumerable<Owner> GetOwnerList()
        {
            return _ownerRepository.GetAll().ToList();
        }

        public void PostOwner(Owner owner)
        {
            _ownerRepository.Post(owner);
        }

        public void UpdateOWner(Owner owner)
        {
           _ownerRepository.Update(owner);
        }
        public void DeleteOwner(Owner owner)
        {
            _ownerRepository.Delete(owner);
        }
    }
}
