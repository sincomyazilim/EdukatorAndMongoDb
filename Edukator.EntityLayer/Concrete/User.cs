﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class User
    {
        [Required]   
        public string Name { get; set; }
       
        [Required]
        [EmailAddress(ErrorMessage = "Mail adresi hatalı")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

      
       

       
    }
}
