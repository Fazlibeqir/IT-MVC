using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [DisplayName("Artist Name")]
        [Required]
        public  string Name { get; set; }
    }
}