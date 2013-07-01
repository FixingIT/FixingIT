using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebBox.Domain.Entities.Abstract;

namespace WebBox.Domain.Entities
{
    [Table("WebBox.UserTheme")]
    public class UserTheme : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The Theme must have a name!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The Theme's name must be between 1 - 50 characters!")]
        [Display(Name = "Name")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "The Theme must have a path!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The Theme's path must be between 1 - 100 characters!")]
        [Display(Name = "Path")]
        public virtual string Path { get; set; }

        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
