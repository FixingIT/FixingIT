using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBox.Domain.Entities
{
    [Table("WebBox.LogOnViewModel")]
    public partial class LogOnViewModel
    {
        //[Required]
        //[Display(Name = "User name")]
        //public string UserName { get; set; }
        [Required]
        [Key]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email is not a valid e-mail address.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public bool EnablePasswordReset { get; set; }
    }
}
