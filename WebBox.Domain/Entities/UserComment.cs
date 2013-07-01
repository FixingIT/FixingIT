using WebBox.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBox.Domain
{
    [Table("WebBox.UserComment")]
    public class UserComment : IEntity
    {
        public virtual int ID { get; set; }

        //[Required(ErrorMessage = "The comment Field can not be empty!?")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "The comment must be between 10 - 500 characters!")]
        //[Display(Name = "Comment")]
        public virtual string Comment { get; set; }

        //[Required(ErrorMessage = "The comment must have a date!")]
        //[Display(Name = "Date")]
        public virtual DateTime Date { get; set; }

        public virtual int NumberOfComments { get; set; }

        public virtual int LogedInUsersID { get; set; }
    }
}
