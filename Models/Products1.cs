﻿using System.ComponentModel.DataAnnotations;

namespace Products.Models
{
    public class Products1
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Products_Details>? Products_Details { get; set; }
    }
}
