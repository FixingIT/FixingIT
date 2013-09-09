using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web.Security;
using FixingIT.Domain;
using FixingIT.Domain.Contexts;
using FixingIT.Domain.Entities;
using WebMatrix.WebData;

namespace FixingIT.Domain.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FixingIT.Domain.Contexts.FixingITDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(FixingIT.Domain.Contexts.FixingITDb context)
        {
            try
            {
                #region UserThemes

                UserTheme DefaultTheme = new UserTheme() { ID = 1, Name = "Default", Path = "/Content/SiteThemes/Default/" };
                UserTheme AmeliaTheme = new UserTheme() { ID = 2, Name = "Amelia", Path = "/Content/SiteThemes/Amelia/" };
                UserTheme CosmoTheme = new UserTheme() { ID = 3, Name = "Cosmo", Path = "/Content/SiteThemes/Cosmo/" };
                UserTheme CyborgTheme = new UserTheme() { ID = 4, Name = "Cyborg", Path = "/Content/SiteThemes/Cyborg/" };
                UserTheme FlatlyTheme = new UserTheme() { ID = 5, Name = "Flatly", Path = "/Content/SiteThemes/Flatly/" };
                UserTheme JournalTheme = new UserTheme() { ID = 6, Name = "Journal", Path = "/Content/SiteThemes/Journal/" };
                UserTheme ReadableTheme = new UserTheme() { ID = 7, Name = "Readable", Path = "/Content/SiteThemes/Readable/" };
                UserTheme SuperheroTheme = new UserTheme() { ID = 8, Name = "Superhero", Path = "/Content/SiteThemes/Superhero/" };

                context.UserThemes.AddOrUpdate(DefaultTheme, AmeliaTheme, CosmoTheme, CyborgTheme, FlatlyTheme, JournalTheme, ReadableTheme, SuperheroTheme);

                context.SaveChanges();

                #endregion

                #region Membership
                WebSecurity.InitializeDatabaseConnection("FixingITDb", "FixingIT.UserProfile", "ID", "Email", autoCreateTables: true);

                var roles = (SimpleRoleProvider)Roles.Provider;
                var membership = (SimpleMembershipProvider)Membership.Provider;

                if (!roles.RoleExists("Administrator"))
                {
                    roles.CreateRole("Administrator");
                }

                if (membership.GetUser("admin@admin.com", false) == null)
                {
                    WebSecurity.CreateUserAndAccount("admin@admin.com", "password", new { UserName = "admin", Description = "I am Studying Web DEV at Jensens", Country = "Sweden", Ocupation = "Web Dev", UserTheme = AmeliaTheme.Name, NrOfComments = 0 });
                    WebSecurity.CreateUserAndAccount("pettan@gmail.com", "pettan1234", new { UserName = "Pettskii", Description = "I am Studying Web DEV at Jensens", Country = "Sweden", Ocupation = "WebMaster at Volvo IT", UserTheme = CosmoTheme.Name, NrOfComments = 0 });
                    WebSecurity.CreateUserAndAccount("john@gmail.com", "john1234", new { UserName = "John77", Description = "I am Studying Web DEV at Jensens", Country = "Sweden", Ocupation = "Web Designer", UserTheme = CyborgTheme.Name, NrOfComments = 0 });
                    WebSecurity.CreateUserAndAccount("henrik@hotmail.com", "henrik1234", new { UserName = "Henrik", Description = "I am Studying Web DEV at Jensens", Country = "Sweden", Ocupation = "Webbutvecklare", UserTheme = SuperheroTheme.Name, NrOfComments = 0 });
                    WebSecurity.CreateUserAndAccount("sofia@gmail.com", "sofia1234", new { UserName = "Soffan", Description = "I am Studying Web DEV at Jensens", Country = "Sweden", Ocupation = "Systemutvecklare", UserTheme = CyborgTheme.Name, NrOfComments = 0 });
                    WebSecurity.CreateUserAndAccount("karin@hotmail.com", "karin1234", new { UserName = "Karino", Description = "I am Studying Web DEV at Jensens", Country = "Sweden", Ocupation = "Webbutvecklare", UserTheme = JournalTheme.Name, NrOfComments = 0 });
                }

                if (!roles.GetRolesForUser("admin@admin.com").Contains("Administrator"))
                {
                    roles.AddUsersToRoles(new[] { "admin@admin.com" }, new[] { "Administrator" });
                }
                #endregion

                #region LanguageTypes


                LanguageType CSS = new LanguageType() { Name = "CSS" };
                LanguageType HTML4 = new LanguageType() { Name = "HTML 4" };
                LanguageType HTML5 = new LanguageType() { Name = "HTML 5" };
                LanguageType Java_Script = new LanguageType() { Name = "Java Script" };
                LanguageType ASPNet_MVC = new LanguageType() { Name = "ASP.Net MVC" };
                LanguageType C_Sharp = new LanguageType() { Name = "C#" };
                LanguageType PHP = new LanguageType() { Name = "PHP" };
                LanguageType Java = new LanguageType() { Name = "Java" };



                context.LanguageTypes.AddOrUpdate(d => d.Name, CSS, HTML4, HTML5, Java_Script, ASPNet_MVC, C_Sharp, PHP, Java);
                //context.LanguageTypes.AddOrUpdate(d => d.Name, HTML4, ASPNet_MVC, C_Sharp, PHP, Java);


                #endregion

                #region User Links

                List<UserLink> lstLinks = new List<UserLink> {
                    new UserLink()
                    {
                        ID = 1,
                        Title = "Bootstrap",
                        URL = "http://twitter.github.io/bootstrap/",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen10.png",
                        Type = Java_Script.Name,
                        UserEmail = "admin@admin.com",
                        LinkRating = -1
                    },
                    new UserLink()
                    {
                        ID = 2,
                        Title = "Knockout.js",
                        URL = "http://knockoutjs.com/",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen20.png",
                        Type = Java_Script.Name,
                        UserEmail = "admin@admin.com",
                        LinkRating = 1
                    },
                    new UserLink()
                    {
                        ID = 3,
                        Title = "Less",
                        URL = "http://lesscss.org/",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen30.png",
                        Type = CSS.Name,
                        UserEmail = "admin@admin.com"
                    },
                    new UserLink()
                    {
                        ID = 4,
                        Title = "Node.js",
                        URL = "http://nodejs.org/",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen40.png",
                        Type = Java_Script.Name,
                        UserEmail = "admin@admin.com"
                    },
                    new UserLink()
                    {
                        ID = 5,
                        Title = "Slider",
                        URL = "http://jqueryui.com/slider/",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen10.png",
                        Type = HTML5.Name,
                        UserEmail = "admin@admin.com"
                    },
                    new UserLink()
                    {
                        ID = 6,
                        Title = "Carousel",
                        URL = "http://twitter.github.io/bootstrap/javascript.html#carousel",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen30.png",
                        Type = Java_Script.Name,
                        UserEmail = "admin@admin.com"
                    },
                    new UserLink()
                    {
                        ID = 7,
                        Title = "Tooltip",
                        URL = "http://twitter.github.io/bootstrap/javascript.html#tooltips",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen40.png",
                        Type = Java_Script.Name,
                        UserEmail = "admin@admin.com"
                    },
                    new UserLink()
                    {
                        ID = 8,
                        Title = "Dropdown",
                        URL = "http://twitter.github.io/bootstrap/javascript.html#dropdowns",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen20.png",
                        Type = Java_Script.Name,
                        UserEmail = "admin@admin.com"
                    },
                    new UserLink()
                    {
                        ID = 9,
                        Title = "Button",
                        URL = "http://twitter.github.io/bootstrap/base-css.html#buttons",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen30.png",
                        Type = CSS.Name,
                        UserEmail = "admin@admin.com"
                    },
                    new UserLink()
                    {
                        ID = 10,
                        Title = "Icon",
                        URL = "http://twitter.github.io/bootstrap/base-css.html#icons",
                        //UserLinkComments = "dfad adfadf adfdfad adsfadf asdfdfad", 
                        Details = "Demo Details",
                        Date = DateTime.Now,
                        //WebImage = "PrintScreen10.png",
                        Type = CSS.Name,
                        UserEmail = "admin@admin.com"
                    }
                };

                foreach (UserLink link in lstLinks)
                {
                    context.UserLinks.AddOrUpdate(link);
                }

                #endregion

                #region Sitepages
                context.SitePages.AddOrUpdate(s => s.Name,
                    new SitePage()
                    {
                        Name = "User Profile",
                        Path = "~/Views/uidf"
                    });
                #endregion

                #region User Comments
                context.UserComments.AddOrUpdate(d => d.Comment,
                    new UserComment()
                    {
                        ID = 1,
                        Comment = "Just a test comment about the Admin",
                        Date = DateTime.Now,
                        NumberOfComments = 1
                        //UsersId = Guid.Parse("{5cfe47d0-14a7-45ee-b578-f01c7856f5a9}") 
                    }
               );
                #endregion

                #region Link Comments

                //context.LinkComments.AddOrUpdate(c => c.Comment,
                //    new LinkComment()
                //    {
                //        ID = 1,
                //        Comment = "Test Comment Google One by admin.",
                //        Date = DateTime.Now,
                //        UserLinkId = 17,
                //        UsersId = Guid.Parse("{5cfe47d0-14a7-45ee-b578-f01c7856f5a9}")
                //    },

                //    new LinkComment()
                //    {
                //        ID = 1,
                //        Comment = "Test Comment Google Two by henrik2.",
                //        Date = DateTime.Now,
                //        UserLinkId = 17,
                //        UsersId = Guid.Parse("{5cfe47d0-14a7-45ee-b578-f01c7856f5a9}")
                //    },

                //    new LinkComment()
                //    {
                //        ID = 1,
                //        Comment = "Test Comment Drupal One by henrik2.",
                //        Date = DateTime.Now,
                //        UserLinkId = 11,
                //        UsersId = Guid.Parse("{5cfe47d0-14a7-45ee-b578-f01c7856f5a9}")
                //    });
                #endregion

                #region LinkVotes
                context.LinkVotes.AddOrUpdate(n => n.UserLinkID,
                    new LinkVote()
                    {
                        ID = 1,
                        UserLinkID = 1,
                        VotersID = 1,
                        VotersEmail = "admin@admin.com",
                        Vote = false
                    },
                    new LinkVote()
                    {
                        ID = 1,
                        UserLinkID = 2,
                        VotersID = 1,
                        VotersEmail = "admin@admin.com",
                        Vote = true
                    }
                    );
                #endregion

                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
        }
    }
}