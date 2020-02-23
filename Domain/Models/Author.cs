using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Domain.Models
{
public partial class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public ICollection<Book> AuthorBooks { get; set; }
    }
}