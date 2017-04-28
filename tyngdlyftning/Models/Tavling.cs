using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tyngdlyftning.Models
{
    public class Tavling
    {
        public int TavlingsId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleate { get; set; }
    }
}