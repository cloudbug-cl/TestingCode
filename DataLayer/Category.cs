using System.ComponentModel.DataAnnotations;
namespace DataLayer.Model
{
    public class Category
    {
        [Key]
        [MaxLength(4)]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}