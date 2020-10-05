using Microsoft.AspNetCore.Mvc;
using ModelValidation.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.Models
{
    public class Appointment
    {
        [Required]
        [Display(Name = "__name__")]
        public string ClientName { get; set; }

        [UIHint("Date")]
        [Required(ErrorMessage = "Please enter a date (from Appointment)")]
        [Remote("ValidateDate", "Home")]
        public DateTime Date { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms (from Appointment)")]
        //[MustBeTrue(ErrorMessage = "You must accept the terms (from Appointment)")]
        [MustBeTrue]
        public bool TermsAccepted { get; set; }
    }
}
