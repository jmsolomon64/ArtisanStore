using System.ComponentModel.DataAnnotations;

namespace ArtisanStore.Data
{
    public class Category
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
    }
}