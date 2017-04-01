using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplicationVidly.Models;

namespace WebApplicationVidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Stock must be between 1 and 30")]
        [Range(1, 30)]
        public int Stock { get; set; }

        public GenreDto Genre { get; set; }
    }
}