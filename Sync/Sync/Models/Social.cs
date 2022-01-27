using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sync.Models
{
    public class Social
    {
        public int ID { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Link { get; set; }
    }
}
