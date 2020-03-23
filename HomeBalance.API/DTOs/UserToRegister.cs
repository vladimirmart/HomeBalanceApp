﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBalance.API.DTOs
{
    public class UserToRegister
    {
        [Required] 
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Locura en el")]
        public string Password { get; set; }        
    }
}
