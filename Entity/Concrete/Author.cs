using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Author
    {
        [Key] public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string AuthorAbout { get; set; }

        public string AuthorImage { get; set; }

        public string AuthorMail { get; set; }

        public string AuthorPassword { get; set; }

        public bool AuthorStatus { get; set; }
    }
}