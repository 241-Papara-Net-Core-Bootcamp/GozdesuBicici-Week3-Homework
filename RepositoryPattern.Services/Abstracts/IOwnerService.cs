using Data.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Services.Abstracts
{
    public interface IOwnerService
    {
        IQueryable<Owner> FindOwner(Expression<Func<Owner, bool>> expression);
        public IEnumerable<Owner> GetOwnerList();        
        public Owner GetOwner(Guid id);
        public void PostOwner(Owner owner);
        public void UpdateOWner(Owner owner);
        public void DeleteOwner(Owner owner);
        

        
        
    }
}
