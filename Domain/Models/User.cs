 using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.ComponentModel.DataAnnotations;
 using System;

namespace BookStoreApi.Domain.Models
{
 public partial class User {
     public int Id { get; set; }
     public string UserName { get; set; }
     public string UserSurname { get; set; }

    [Required]
     public DateTime DateRegistered { get; set; }

     public bool IsActive { get; set; }
 
 }
}