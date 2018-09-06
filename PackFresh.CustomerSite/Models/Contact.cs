﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PackFresh.CustomerSite.Models
{
    public class Contact
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Company { get; set; }

        [Required]
        public string Subject { get; set; }
        
        [Required]
        public string Message { get; set; }
    }
}
