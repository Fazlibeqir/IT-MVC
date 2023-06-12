using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class AddToStore
    {
        public int storeId { get; set; }
        public int albumId { get; set; }
        public List<Albums> albums { get; set; }
        public AddToStore()
        {
            albums = new List<Albums>();
        }
    }
}