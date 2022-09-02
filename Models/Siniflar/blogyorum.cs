using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vs1.Models.Siniflar
{
    public class blogyorum
    {
        public IEnumerable<blog> deger1 { get; set; }
        public IEnumerable<yorumlar> deger2 { get; set; }
    }
}