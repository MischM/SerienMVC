using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SerienMVC.Models
{
    public class GenreMetadata
    {
        [Required(ErrorMessage = "Please insert a name")]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name;

    }
}