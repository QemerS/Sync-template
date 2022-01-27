using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sync.Models
{
    public class Setting
    {
        public int ID { get; set; }
        [MaxLength(255)]
        public string Logo { get; set; }
        [Column("nText")]
        public string About { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Mail { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
    }
}
