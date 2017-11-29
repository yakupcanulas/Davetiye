using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnePage.Models
{
    public class Dugun
    {
        [Key]
        public int DugunID { get; set; }
        public string GelinIsim { get; set; }
        public string DamatIsim { get; set; }
        public DateTime Tarih { get; set; }
        public string Adres { get; set; }
    }
}