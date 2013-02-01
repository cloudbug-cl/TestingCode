using System.ComponentModel.DataAnnotations;
namespace DataLayer.Model
{
    public class Customer
    {
        [Key]
        [MaxLength(6)]
        public string Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Contact { get; set; }
    }
}