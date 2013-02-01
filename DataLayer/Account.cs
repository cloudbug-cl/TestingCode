using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Model
{
    [Table("Accounts", Schema="ABC Ltd")]
    public class Account
    {
        [Key]
        [MaxLength(6)]
        public string Id {get;set;}
        [MaxLength(40)]
        [Required]
        public string Name {get;set;}
        [MaxLength(100)]
        public string Description {get;set;}
        public decimal Balance { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public string CategoryId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public string CustomerId { get; set; }
        
    }
}
