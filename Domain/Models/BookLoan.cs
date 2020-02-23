 using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
 using System;

 namespace BookStoreApi.Domain.Models {
     public partial class BookLoan {
         public int Id { get; set; }

         [Required]
         public DateTimeOffset? DueAt { get; set; }

         [Required]
         public DateTime LoanedAt { get; set; }
         public Book Book { get; set; }
         public User User { get; set; }
     }
 }