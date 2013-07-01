using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebBox.Domain.Entities.Abstract;

namespace WebBox.Domain
{
    [Table("WebBox.LanguageType")]
    public class LanguageType : IEntity
    {
        public virtual int ID { get; set; }

        [Required(ErrorMessage = "The LanguageType must have a name!"), Key]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The LanguageType's name must be between 1 - 100 characters!")]
        [Display(Name = "Name")]
        public virtual string Name { get; set; }

        [Display(Name = "Links")]
        public virtual ICollection<UserLink> Links { get; set; }
    }
}