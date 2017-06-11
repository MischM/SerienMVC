using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SerienMVC.Models
{
    public class SerieMetadata
    {
        [Required(ErrorMessage = "Please insert a name")]
        [StringLength(100)]
        [Display(Name = "Serie name")]
        public string SerieName;

        [Required(ErrorMessage = "Please insert a rating")]
        [Display(Name = "Rating")]
        public string Rating;

        [Required(ErrorMessage = "Please insert a release date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release date")]
        public string ReleaseDate;
    }
}