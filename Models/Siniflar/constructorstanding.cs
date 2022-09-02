using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vs1.Models.Siniflar
{
    public class constructorstanding
    {
        [Key]
        public int ID { get; set; }
        public int position { get; set; }
        public string carname { get; set; }
        public string drivername { get; set; }
        public int points { get; set; }
    }
}