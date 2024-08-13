using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogCodeFirstEF.Models
{
    public class Blog
    {
        public Blog()
        {
            posts = new List<Post>();
        }


        [Key]
        public int b_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(50)]
        public string desc { get; set; }

        public virtual List<Post> posts { get; set; }

        [ForeignKey("owner")]
        public int o_Id { get; set; }
        public virtual Owner owner { get; set; }

    }
}
