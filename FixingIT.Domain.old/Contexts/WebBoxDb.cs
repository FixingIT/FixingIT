using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBox.Domain;
//using WebBox.Domain.Entities;
using WebBox.Domain.Contexts;
using System.Web;
using WebBox.Domain.Entities;

namespace WebBox.Domain.Contexts
{
        //public WebBoxDb() : base("WebBoxDb")    
        //{

        //}

    public class WebBoxDb : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserLink> UserLinks { get; set; }
        public DbSet<LanguageType> LanguageTypes { get; set; }
        public DbSet<SitePage> SitePages { get; set; }
        public DbSet<UserTheme> UserThemes { get; set; }
        public DbSet<UserComment> UserComments { get; set; }
        public DbSet<UsersSkillLevel> UsersSkillLevels { get; set; }
        public DbSet<LinkComment> LinkComments { get; set; }
        public DbSet<RegisterExternalLoginModel> RegisterExternalLoginModels { get; set; }
        public DbSet<LogOnViewModel> LogOnViewModels { get; set; }
        public DbSet<LinkVote> LinkVotes { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Membership>()
        //        .HasMany<Role>(r => r.Roles)
        //        .WithMany(u => u.Members)
        //        .Map(m =>
        //        {
        //            m.ToTable("UsersInRoles");
        //            m.MapLeftKey("UserId");
        //            m.MapRightKey("RoleId");
        //        });
        //}
    }


}
