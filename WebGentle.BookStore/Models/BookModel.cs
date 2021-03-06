using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore.Models
{
    public class BookModel
    {
        //[DataType(DataType.Password)]
        //public string MyField { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the title of your book.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter your name.")]
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public List<string> MultiLanguage { get; set; }

        [Required]
        [Display(Name ="Total pages of book")]
        public int TotalPages { get; set; }
    }
}
