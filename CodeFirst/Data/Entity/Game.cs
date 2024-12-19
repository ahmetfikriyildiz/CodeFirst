using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Entity
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string Platform { get; set; }
        [Required]
        [Precision(3,2)]
        public decimal Rating { get; set; }
    }
}
