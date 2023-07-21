using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Scrumapp.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string LastName { get; set; }
        
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
