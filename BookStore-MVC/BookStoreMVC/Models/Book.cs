using System.ComponentModel.DataAnnotations;

namespace BookStoreMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be positive")]
        public double Price { get; set; }

    }
}

