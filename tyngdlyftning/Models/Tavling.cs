using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tyngdlyftning.Models
{
    [Table("Tavling")]
    public class Tavling
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TavlingsId { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsCompleate { get; set; }
    }
}