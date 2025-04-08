using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class BookModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Author name is too long.")]
        public string Author { get; set; }

        [Range(1, 100, ErrorMessage = "Price must be a positive number.")]
        public decimal Price { get; set; }
    }
}
