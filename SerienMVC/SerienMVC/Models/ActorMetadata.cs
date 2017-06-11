using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SerienMVC.Models
{
    public class ActorMetadata
    {
        [Required(ErrorMessage = "Please insert a firstname")]
        [StringLength(100)]
        [Display(Name = "Firstname")]
        public string FirstName;

        [Required(ErrorMessage = "Please insert a lastname")]
        [StringLength(100)]
        [Display(Name = "Lastname")]
        public string LastName;
    }
}