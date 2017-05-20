using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidleyMVC.Models;

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
    }
}