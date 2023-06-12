using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class Albums
    {
        [Key]
        public int Id { get; set; }
        public int GenreId { get; set; }
        [DisplayName("Image")]
        public int  ArtistId { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(0, 5000)]
        public decimal  Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public  Genre Genre { get; set; }
        public Artist Artist { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Store> stores { get; set; }
        public Albums() {
            stores = new List<Store>();
        }
    }
}