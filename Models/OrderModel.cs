using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Book title is required.")]
        [MinLength(10, ErrorMessage = "Book title length needs to be more than 10 characters.")]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Range (1, 100, ErrorMessage = "Too many or less than one book.")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Addressis required.")]
        [MinLength(3, ErrorMessage = "Address too short.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; }
    }
}
