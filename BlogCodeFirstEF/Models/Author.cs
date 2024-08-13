using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCodeFirstEF.Models
{
    public class Author
    {
        public Author()
        {
            Posts = new List<Post>();
        }
        [Key]
        public int auth_id { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
        public int? age { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public bool auth_isBlocked { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
