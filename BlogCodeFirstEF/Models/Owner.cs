using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogCodeFirstEF.Models
{
    public class Owner
    {
        [Key]
        public int o_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        public int? age { get; set; }
        public string password { get; set; }


        public Blog blog { get; set; }
    }
}
