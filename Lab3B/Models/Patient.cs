using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Lab3B.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        [Display(Name = "Код на пациентот")]
        [Required(ErrorMessage = "The Patient Code field is required.")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "The Patient Code must be a 5-digit number.")]
        public int PatientCode { get; set; }
        public Gender Gender { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}