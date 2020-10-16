using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicWebsite.Models
{
    public class Music
    {
        [ScaffoldColumn(false)]
        public int MusicID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string MusicName { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"),
        DataType(DataType.MultilineText)]
        public string Information { get; set; }
        public string ImagePath { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}