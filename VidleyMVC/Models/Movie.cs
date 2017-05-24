using System;
using System.ComponentModel.DataAnnotations;

namespace VidleyMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public GenreType GenreType { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
        [Range(1, 20)]
        public int NumberAvailable { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreTypeId { get; set; }
        
    }
}