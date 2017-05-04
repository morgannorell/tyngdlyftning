using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tyngdlyftning.Models
{
    [Table("Team")]
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }

        [MaxLength(255)]
        [Required]
        [DisplayName("Klubbnamn")]
        public string TeamName { get; set; }

        [MaxLength(1024)]
        [DisplayName("Adress")]
        public string Address { get; set; }

        [MaxLength(25)]
        [DisplayName("Postnummer")]
        public string Pnr { get; set; }

        [MaxLength(50)]
        [DisplayName("Ort")]
        public string City { get; set; }

        [MaxLength(25)]
        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [MaxLength(50)]
        [DisplayName("E-post")]
        public string Email { get; set; }
    }
}