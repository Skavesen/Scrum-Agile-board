﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Scrumapp.Data.Models;

namespace Scrumapp.WebMvcUI.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public bool IsAdmin { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Максимум 50 символов")]
        public string LastName { get; set; }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
