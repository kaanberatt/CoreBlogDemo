using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string  BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime CreateDate {get; set;}
        public bool BlogStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<Comment> Comments { get; set; }
    }
}