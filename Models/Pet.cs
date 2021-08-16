using System;
using System.ComponentModel.DataAnnotations;

namespace firstMVC.Models
{
    public class Pet
    {
        [Required(ErrorMessage = "Name is required!!")]
        public string Name {get; set;}
        [Required]
        [MinLength(2)]
        public string Species {get; set;}
        [Required]
        public int Age {get; set;}
    }
}