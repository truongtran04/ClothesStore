﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; }
    }
}