using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBox.Domain.Entities
{
    [Table("WebBox.UserRating")]
    class UserRating
    {
        public int ID { get; set; }
        public int userRatingValue { get; set; }
        public virtual int LogedInUsersID { get; set; }
    }
}
