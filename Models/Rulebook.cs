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
        public string Edition { get; set; }

        [Required]
        [Range(1990, 2030)]
        public string Publication { get; set; }

        [Required]
        [Range(50, 1000)]
        public string PageNumbers { get; set; }
    }
}
