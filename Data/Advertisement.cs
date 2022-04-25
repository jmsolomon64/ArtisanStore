using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtisanStore.Data
{
    public class Advertisement
    {
        [Key]
        public int AdId {get; set;} 
        [ForeignKey("User")]
        public int UserId {get; set;} //tracks user who Posted advertisement
        [Required]
        public DateTime DatePosted {get; set;} //Stores date ad was posted
        [Required]
        public DateTime ExpirationDate {get; set;} //will automatically DELETE ad once the date hits

    }
}