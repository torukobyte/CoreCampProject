using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Blog
    {
        [Key] public int BlogId { get; set; }

        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public string BlogThumbnailImage { get; set; }

        public string BlogImage { get; set; }

        public DateTime BlogCreateDate { get; set; }

        public bool BlogStatus { get; set; }
    }
}