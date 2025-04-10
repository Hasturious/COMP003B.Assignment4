using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class Rulebook
    {
        [Required]
        [MinLength(10)]
        public string Title { get; set; }

        [Required]
        [Range(1, 10)]
        public int Edition { get; set; }

        [Required]
        [Range(1990, 2030)]
        public int Publication { get; set; }

        [Required]
        [Range(50, 1000)]
        public int PageNumbers { get; set; }
    }
}
