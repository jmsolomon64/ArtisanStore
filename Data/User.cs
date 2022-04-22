using System.ComponentModel.DataAnnotations;

namespace ArtisanStore.Data
{
    public class User
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        public DateTime Joined {get; set;}
    }
}