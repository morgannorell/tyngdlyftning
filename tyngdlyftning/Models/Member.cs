using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tyngdlyftning.Models
{
    [Table("Member")]
    public class Member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Förnamn")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Efternamn")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        [DisplayName("Personnummer")]
        public string LiftId { get; set; } // personnummer 6 siffror

        [MaxLength(100)]
        [DisplayName("Adress")]
        public string Address { get; set; }

        [MaxLength(100)]
        [DisplayName("Postnummer")]
        public string Pnr { get; set; }

        [MaxLength(50)]
        [DisplayName("Stad")]
        public string City { get; set; }

        [MaxLength(25)]
        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [MaxLength(50)]
        [DisplayName("E-post")]
        public string Email { get; set; }
    }
}