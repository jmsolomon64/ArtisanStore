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
        [Required]

        public bool isVendor {get; set;} //setting to true gives access to inventory manipulation and advertisement functionality
        [Required]

        public bool isAdvertiser {get; set;} //will lock out functionality to only manipulating ads
    }
}