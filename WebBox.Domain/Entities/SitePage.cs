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
    [Table("WebBox.SitePage")]
    public class SitePage : IEntity
    {
        [Required(ErrorMessage = "The SitePage type must have an ID!"), Key]
        [Display(Name = "ID")]
        public virtual int ID { get; set; }

        [Required(ErrorMessage = "The SitePage must have a name!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The SitePage's name must be between 1 - 100 characters!")]
        [Display(Name = "Name")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "The SitePage must have a path!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The SitePage's path must be between 1 - 100 characters!")]
        [Display(Name = "Path")]
        public virtual string Path { get; set; }
    }
}
