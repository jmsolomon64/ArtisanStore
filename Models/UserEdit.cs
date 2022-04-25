using System.ComponentModel.DataAnnotations;

namespace ArtisanStore.Models
{
    public class UserEdit
    {
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        public bool IsVendor {get; set;}
        [Required]
        public bool IsAdvertiser {get; set;}
    }
}