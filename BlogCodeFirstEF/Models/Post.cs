using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogCodeFirstEF.Models
{
    public class Post
    {
        [Key]
        public int p_id { get; set; }
        public string title { get; set; }
        public string brief { get; set; }
        public string desc { get; set; }
        public string? p_media { get; set; }
        public DateTime p_date { get; set; }

        public Blog blog { get; set; }

        [ForeignKey("auther")]
        public int? author_id { get; set; }
        public virtual Author author { get; set; }
        [ForeignKey("blog")]
        public int BlogId { get; set; }
    }
}
