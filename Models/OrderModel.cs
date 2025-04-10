using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class Order
    {
        [Required]
        [MinLength(3)]
        public string BookTitle { get; set; }

        [Required]
        [MinLength(3)]
        public string Address { get; set; }

        [Required]
        [MinLength(3)]
        public string Email { get; set; }
    }
}
