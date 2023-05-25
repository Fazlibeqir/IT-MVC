using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3B.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        public string Image { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}