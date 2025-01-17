using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Products_Details
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Products")]
        public int Products_Id { get; set; }

        [Required]
        public string Color { get; set; } = string.Empty; // أضف قيمة افتراضية

        [Required]
        public string Image { get; set; } = string.Empty; // أضف قيمة افتراضية

        [Required]
        public int QTY { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual Products1? Products { get; set; } // اجعلها nullable
    }
}
