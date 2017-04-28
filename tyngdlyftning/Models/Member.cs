using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tyngdlyftning.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LiftId { get; set; }
        public string Address { get; set; }
        public string Pnr { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}