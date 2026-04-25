using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication0407.Models
{
    [Table("products")]
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is needed")]
        public string Title { get; set; } = string.Empty;
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
