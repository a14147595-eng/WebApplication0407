using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication0407.Models
{
    [Index(nameof(Username), IsUnique = true)]
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage ="can't be over 20 characters")]
        public string Username { get; set; } = string.Empty;
        [Required]
        [MinLength(3, ErrorMessage ="password must be at least over 3 characters")]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Role { get; set; } = string.Empty;
    }
}
