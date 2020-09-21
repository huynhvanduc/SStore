﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models {

    public class Product {

        public long ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a product Description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }
    }
}
