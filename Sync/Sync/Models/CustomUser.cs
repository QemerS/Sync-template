using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sync.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength(10)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Surname { get; set; }
        [MaxLength(15)]
        public string Password { get; set; }
    }
}
