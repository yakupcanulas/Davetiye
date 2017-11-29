using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnePage.Models
{
    public class Slider
    {
        [Key]
        public int SliderID { get; set; }
        public string ResimURL { get; set; }
        public string Aciklama { get; set; }
    }
}