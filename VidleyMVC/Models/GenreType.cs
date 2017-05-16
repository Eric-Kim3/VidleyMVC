using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Build.Framework;

namespace VidleyMVC.Models
{
    public class GenreType
    {
        public byte Id { get; set; }
        [Required]
        public string Genre { get; set; }

    }
}