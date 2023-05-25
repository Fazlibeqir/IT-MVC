using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3B.Models
{
    public class Doctor
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}