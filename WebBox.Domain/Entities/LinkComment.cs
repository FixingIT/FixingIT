using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBox.Domain.Entities.Abstract;

namespace WebBox.Domain.Entities
{
    [Table("WebBox.LinkComment")]
    public class LinkComment : IEntity
    {
        public virtual int ID { get; set; }
        public virtual int UserLinkId { get; set; }
        public virtual int LogedInUsersID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string UserImage { get; set; }
        public virtual string UserLevel { get; set; }
        [Required(ErrorMessage = "Cannot post an empty comment.")]
        [StringLength(140, MinimumLength = 1, ErrorMessage = "Message can only be 140 digits.")]
        [Display(Name = "Comment")]
        public virtual string Comment { get; set; }
        [Required]
        public virtual DateTime Date { get; set; }
        public virtual DateTime? LastEditDate { get; set; }
        public virtual UserLink UserLink { get; set; }
    }
}
