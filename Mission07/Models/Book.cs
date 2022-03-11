using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mission07.Models
{
    public partial class Book
    {
        [Key] 
        [Required]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Please enter a Book Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter an Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter a Publisher")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Please enter an ISBN")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "Please enter an Classification")]
        public string Classification { get; set; }
        [Required(ErrorMessage = "Please enter a Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter a PageCount")]
        public int PageCount { get; set; }
        [Required(ErrorMessage = "Please enter a Price")]
        public double Price { get; set; }

    }
}
