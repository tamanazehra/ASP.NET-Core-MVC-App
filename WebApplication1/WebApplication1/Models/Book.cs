using System.ComponentModel.DataAnnotations;

namespace BookStoreMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Author { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

    }
}
