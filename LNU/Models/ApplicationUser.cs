using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LNU.Models
{
    public class User : IdentityUser
    {
        public bool? IsSystemAdmin { get; set; }

        [Required]
        [StringLength(128)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(128)]
        public string LastName { get; set; }
    }
}
