using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Entity
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
    }
}
