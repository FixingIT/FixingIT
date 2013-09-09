using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using FixingIT.Domain;
using FixingIT.Domain.Entities;
using FixingIT.Domain.Contexts;

namespace FixingIT.Domain.Contexts
{
    //public FixingITDb() : base("FixingITDb")    
    //{

    //}

    public class FixingITDb : DbContext
    {
        public DbSet<Refrence> Refrences { get; set; }
        public DbSet<SitePage> SitePages { get; set; }
        public DbSet<RegisterExternalLoginModel> RegisterExternalLoginModels { get; set; }
        public DbSet<LogOnViewModel> LogOnViewModels { get; set; }
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
