using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnePage.Models
{
    public class HikayeViewModel
    {
        public string Gelin { get; set; }
        public string Damat { get; set; }
        public MutluHikaye Hikaye {get;set;}
    }
}