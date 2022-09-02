using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vs1.Models.Siniflar
{
    public class test
    {
        [Key]
        public int ID { get; set; }
        public string grandprix { get; set; }
        public DateTime date { get; set; }
        public string winner { get; set; }
        public string winnercar { get; set; }
        public int laps { get; set; }
    }
}