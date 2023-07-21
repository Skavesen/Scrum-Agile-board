using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Scrumapp.WebMvcUI.Models.UserViewModels
{
    public class UserCreateViewModel
    {
        public bool IsAdmin { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Длина {0} должна составлять не менее {2} и не более {1} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароль и пароль подтверждения не совпадают.")]
        public string ConfirmPassword { get; set; }
        
        public IFormFile Image { get; set; }
    }
}
