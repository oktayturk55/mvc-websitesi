using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vs1.Models.Siniflar
{
    public class yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string kullaniciadi { get; set; }
        public string yorum { get; set; }
        public blog blogs { get; set; }
    }
}