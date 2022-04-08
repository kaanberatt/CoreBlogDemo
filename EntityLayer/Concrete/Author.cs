using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorAbout { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorMail { get; set; }
        public string AuthorPassword { get; set; }
        public bool AuthorStatus { get; set; }
        public List<Blog> Blogs {get; set;}
    }
}