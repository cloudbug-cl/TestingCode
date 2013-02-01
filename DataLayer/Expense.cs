using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    [Table("Expenses", Schema="ABC Ltd")]
    public class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime NowTime { get; set; }
        [MaxLength(6)]
        public string AccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime EffectiveTime { get; set; }
        [MaxLength(50)]
        public string Comments { get; set; }
    }
}