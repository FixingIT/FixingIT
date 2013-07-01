using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebBox.Domain.Entities.Abstract;
using WebBox.Domain.Entities;
using System.ComponentModel;

namespace WebBox.Domain
{
    [Table("WebBox.LinkVote")]
    public class LinkVote : IEntity
    {
        [Key]
        public virtual int ID { get; set; }

        [Required(ErrorMessage="The vote must contain a link ID.")]
        public virtual int UserLinkID { get; set; } // fake foreign key

        [Required(ErrorMessage = "The vote must contain a user ID.")]
        public virtual int VotersID { get; set; } // the id of the loged in user who voted/rated the link

        [Required(ErrorMessage = "The vote must contain a user e-mail.")]
        [EmailAddress(ErrorMessage="The voters e-mail is not a valid e-mail address.")]
        public virtual string VotersEmail { get; set; } // the email of the loged in user who voted/rated the link

        [DefaultValue(false)]
        [Required(ErrorMessage = "The vote must contain a vote?!?")]
        public virtual bool Vote { get; set; }
    }
}