using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Scrumapp.WebMvcUI.Models.UserViewModels
{
    public class UserDetailViewModel
    {
        public string Id { get; set; }

        public SelectList ApplicationRoles { get; set; }
        [Display(Name = "Роль")]
        public string UserRoleId { get; set; }

        public string CurrentUserRole { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string LastName { get; set; }

        public string Username { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string ImageUrl { get; set; }

        [Phone]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
