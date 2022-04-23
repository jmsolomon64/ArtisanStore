using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtisanStore.Data
{
    public class Product 
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        public int Upc {get; set;}
        [ForeignKey("Category")]
        [Required]
        public int CategoryId {get; set;}
        [Required]
        public int OnHand {get; set;} //tracks amount of product in inventory
    }
}