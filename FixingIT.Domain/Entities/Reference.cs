using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FixingIT.Domain.Entities.Abstract;
using FixingIT.Domain.Entities;

namespace FixingIT.Domain
{
    [Table("FixingIT.Refrence")]
    public class Refrence : IEntity
    {
        public virtual int ID { get; set; }

        [Required(ErrorMessage = "The link must have a title!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The links's title must be between 1 - 100 characters!")]
        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Required(ErrorMessage = "The link must have some details!")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "The links's details must be between 10 - 500 characters!")]
        [Display(Name = "Details")]
        public virtual string Details { get; set; }

        [Required(ErrorMessage = "The link must have a URL!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The links's URL must be between 5 - 100 characters!")]
        [Display(Name = "URL")]
        public virtual string URL { get; set; }

        [Required(ErrorMessage = "The link must have a date!")]
        [Display(Name = "Date")]
        public virtual DateTime Date { get; set; }

        public virtual int LinkRating { get; set; }

        [Required(ErrorMessage = "The link must be connected to a script language!")]
        [Display(Name = "Type")]
        public virtual string Type { get; set; }

        [Required(ErrorMessage = "The link must be connected to a user using the users e-mail!")]
        [Display(Name = "User Email")]
        public virtual string UserEmail { get; set; }
    }
}