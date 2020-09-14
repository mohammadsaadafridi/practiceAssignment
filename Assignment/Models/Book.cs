using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace Assignment.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }


    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}