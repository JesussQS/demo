using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace webapp.Models
{
    public class Contacto
    {
        [Required]
        [Display( Name= "First Name", Prompt ="Enter first name")]
        public String? FirstName {get;set;}
        [Required]
        [Display( Name= "Last Name", Prompt ="Enter last name")]
        public String? LastName {get;set;}
        [Required]
        [Display( Name= "Job Title",Prompt ="Enter your job title")]
        public String? Job {get;set;}
        [Required]
        [Display( Name= "Highest level of education")]
        public String? Education {get;set;}
        [Required]
        public String? Sex{get;set;}
        [Required]
        [Display( Name= "Years of experience")]
        public String? Experience{get;set;}
        public List<SelectListItem> YearsExperiencie { get;} = new List<SelectListItem>{
            new SelectListItem { Value = "0-1", Text = "0-1" },
            new SelectListItem { Value = "2-4", Text = "2-4" },
            new SelectListItem { Value = "5-9", Text = "5-9"  },
            new SelectListItem { Value = "10+", Text = "10+"  },
        };
        [Required]
        [Display( Name= "Date")]
        [DataType(DataType.Date)]
        public DateTime Date{get;set;}

    }
}