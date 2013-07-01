using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBox.Domain.Entities.Abstract;

namespace WebBox.Domain.Entities
{
    [Table("WebBox.UserProfile")]
    public class UserProfile : IEntity
    {
        public virtual int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The username must be between 1 - 100 characters!")]
        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Description { get; set; }
        public virtual string Country { get; set; }
        public virtual string Ocupation { get; set; }
        public virtual string UserTheme { get; set; }
        [DefaultValue(0)]
        public virtual int NrOfComments { get; set; }
    }
}
