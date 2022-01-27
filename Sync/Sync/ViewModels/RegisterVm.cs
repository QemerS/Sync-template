using Sync.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sync.ViewModels
{
    public class RegisterVm
    {
        [MaxLength(10)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Surame { get; set; }
        [MaxLength(15), Required]
        public string Password { get; set; }
        [MaxLength(255), Required]
        public string Email { get; set; }
    }
}
