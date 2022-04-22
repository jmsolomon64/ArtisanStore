using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtisanStore.Data
{
    public class Order
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        [ForeignKey("Product")]
        public int ProductId {get; set;}
        [Required]
        [ForeignKey("User")]
        public int UserIdBuy {get; set;}
        [Required]
        [ForeignKey("User")] //we'll probably need to ask Marty how to program a difference between these last two foreign keys
        public int UserIdSell {get; set;}
    }
}