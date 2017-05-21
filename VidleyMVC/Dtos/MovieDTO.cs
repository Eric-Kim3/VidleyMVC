using System;
using System.ComponentModel.DataAnnotations;

namespace VidleyMVC.Dtos
{
    public class MovieDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
        [Required]
        public byte GenreTypeId { get; set; }
        public GenreTypeDTO GenreType { get; set; }

    }
}