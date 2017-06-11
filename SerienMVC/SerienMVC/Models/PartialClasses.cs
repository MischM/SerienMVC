using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SerienMVC.Models
{
    public class PartialClasses
    {
        [MetadataType(typeof(ActorMetadata))]
        public partial class Actor
        {
        }
        [MetadataType(typeof(SerieMetadata))]
        public partial class Serie
        {
        }
        [MetadataType(typeof(GenreMetadata))]
        public partial class Genre
        {
        }

    }
}