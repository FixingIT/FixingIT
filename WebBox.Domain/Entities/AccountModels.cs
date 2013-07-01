using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using WebBox.Domain.Entities.Abstract;

namespace WebBox.Domain.Entities
{
    [Table("WebBox.RegisterExternalLoginModel")]
    public class RegisterExternalLoginModel
    {
        //[Required]   THis is the one that braeks fb login
        [Display(Name = "Your Email")]
        [Key]
        [EmailAddress(ErrorMessage = "Email is not a valid e-mail address.")]
        public string Email { get; set; }

        public string ExternalLoginData { get; set; }
    }

    [Table("WebBox.RegisterModel")]
    public class LocalPasswordModel
    {
        [Required(ErrorMessage = "Old password isn't correct.")]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    [Table("WebBox.RegisterModel")]
    public class LoginModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email is not a valid e-mail address.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    [Table("WebBox.RegisterModel")]
    public class RegisterModel
    {
        //[Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email is not a valid e-mail address.")]
        public string Email { get; set; }

        public virtual DateTime Date { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }

    [Table("WebBox.ExternalLogin")]
    public class ExternalLogin
    {
        public virtual DateTime Date { get; set; }
        [Display(Name = "mail")]
        [EmailAddress(ErrorMessage = "Email is not a valid e-mail address.")]
        public string Email { get; set; }
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
