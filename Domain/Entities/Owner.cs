﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    
    public class Owner
    {
        public Guid OwnerId { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(60,ErrorMessage ="Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Adress is required")]
        [StringLength(100, ErrorMessage = "Adress can't be longer 100 characters")]
        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}