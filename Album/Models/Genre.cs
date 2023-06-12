using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class Genre
    {
        [Display(Name = "Id")]
        [Key]
        public int GenreId { get; set; }
        [Display(Name ="Genre Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Albums> Albums { get; set; }

    }
}