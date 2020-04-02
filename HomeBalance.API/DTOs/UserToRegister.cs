using System;
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
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Debe tener mas de 8 caracteres")]
        public string Password { get; set; }        
    }
}
