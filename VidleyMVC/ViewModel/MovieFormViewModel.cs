using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VidleyMVC.Models;

namespace VidleyMVC.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }

        public int? Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreTypeId { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        public string TitleHeading
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreTypeId = movie.GenreTypeId;
        }
    }
}