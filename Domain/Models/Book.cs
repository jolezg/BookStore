using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Domain.Models {
    public partial class Book {
        public int Id { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Name { get; set; }

        [Column (TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}