using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tyngdlyftning.Models
{
    public class ExpandedUserDTO
    {
        [Key]
        [Display(Name = "Användarnamn")]
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Display(Name = "Slutdatum för utlåsning av konto")]
        public DateTime? LockoutEndDateUtc { get; set; }

        public int AccessFailedCount { get; set; }

        public string PhoneNumber { get; set; }

        public IEnumerable<UserRolesDTO> Roles { get; set; }
    }

    public class UserRolesDTO
    {
        [Key]
        [Display(Name = "Namn på roll")]
        public string RoleName { get; set; }
    }

    public class UserRoleDTO
    {
        [Key]
        [Display(Name = "Användarnamn")]
        public string UserName { get; set; }

        [Display(Name = "Namn på roll")]
        public string RoleName { get; set; }
    }

    public class RoleDTO
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Namn på roll")]
        public string RoleName { get; set; }
    }

    public class UserAndRolesDTO
    {
        [Key]
        [Display(Name = "Användarnamn")]
        public string UserName { get; set; }

        public List<UserRoleDTO> colUserRoleDTO { get; set; }
    }
}