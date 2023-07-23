﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Edukator.EntityLayer.Concrete
{
   public class AppUser1:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
       
        [StringLength(100)]
        public string ImageUrl { get; set; }

        public List<CourseRegister> CourseRegisters { get; set; }
    }
}
