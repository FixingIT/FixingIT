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
    [Table("WebBox.UsersSkillLevel")]
    public class UsersSkillLevel : IEntity
    {
        public int ID { get; set; }

        public string Level { get; set; }
        public string Type { get; set; }
        public virtual int LogedInUsersID { get; set; }

        //public virtual ICollection<LanguageType> LanguageTypes { get; set; }

    }
}
