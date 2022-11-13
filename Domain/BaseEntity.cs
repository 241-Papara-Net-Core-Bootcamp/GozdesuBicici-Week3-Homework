using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public string LastUpdateBy { get; set; }
    }
}
