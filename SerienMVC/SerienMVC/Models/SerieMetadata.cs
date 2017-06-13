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
        [Range(0,10,ErrorMessage = "Rating must be between 0 and 10.")]
        [Display(Name = "Rating")]
        public string Rating;

        [Required(ErrorMessage = "Please insert a release date")]
        [DataType(DataType.Date, ErrorMessage ="Please insert a valid date")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release date")]
        public string ReleaseDate;
    }
}