namespace FixingIT.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_New_Db_20130621_Kl001000 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FixingIT.UserProfile",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100),
                        UserName = c.String(),
                        Description = c.String(),
                        Country = c.String(),
                        Ocupation = c.String(),
                        UserTheme = c.String(),
                        NrOfComments = c.Int(nullable: false),
                        UserTheme_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FixingIT.UserTheme", t => t.UserTheme_ID)
                .Index(t => t.UserTheme_ID);
            
            CreateTable(
                "dbo.FixingIT.UserLink",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Details = c.String(nullable: false, maxLength: 500),
                        URL = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                        LinkRating = c.Int(nullable: false),
                        Type = c.String(nullable: false),
                        UserEmail = c.String(nullable: false),
                        LanguageType_Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FixingIT.LanguageType", t => t.LanguageType_Name)
                .Index(t => t.LanguageType_Name);
            
            CreateTable(
                "dbo.FixingIT.LinkVote",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserLinkID = c.Int(nullable: false),
                        VotersID = c.Int(nullable: false),
                        VotersEmail = c.String(nullable: false),
                        Vote = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FixingIT.UserLink", t => t.UserLinkID, cascadeDelete: true)
                .Index(t => t.UserLinkID);
            
            CreateTable(
                "dbo.FixingIT.LinkComment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserLinkId = c.Int(nullable: false),
                        LogedInUsersID = c.Int(nullable: false),
                        UserName = c.String(),
                        UserImage = c.String(),
                        UserLevel = c.String(),
                        Comment = c.String(nullable: false, maxLength: 140),
                        Date = c.DateTime(nullable: false),
                        LastEditDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FixingIT.UserLink", t => t.UserLinkId, cascadeDelete: true)
                .Index(t => t.UserLinkId);
            
            CreateTable(
                "dbo.FixingIT.LanguageType",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 100),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.FixingIT.SitePage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FixingIT.UserTheme",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FixingIT.UserComment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        Date = c.DateTime(nullable: false),
                        NumberOfComments = c.Int(nullable: false),
                        LogedInUsersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FixingIT.UsersSkillLevel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Level = c.String(),
                        Type = c.String(),
                        LogedInUsersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FixingIT.RegisterExternalLoginModel",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        ExternalLoginData = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.FixingIT.LogOnViewModel",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        RememberMe = c.Boolean(nullable: false),
                        EnablePasswordReset = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Email);

            CreateIndex(
                    table: "dbo.FixingIT.UserProfile",
                    column: "Email",
                    unique: true);

            CreateIndex(
                    table: "dbo.FixingIT.UserTheme",
                    column: "Name",
                    unique: true);

            CreateIndex(
                    table: "dbo.FixingIT.UserLink",
                    column: "Title",
                    unique: true);

            CreateIndex(
                    table: "dbo.FixingIT.LanguageType",
                    column: "Name",
                    unique: true);

            CreateIndex(
                    table: "dbo.FixingIT.SitePage",
                    column: "Name",
                    unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex(table: "dbo.FixingIT.UserProfile", name: "Email");
            DropIndex(table: "dbo.FixingIT.UserThemes", name: "Name");
            DropIndex(table: "dbo.FixingIT.UserLink", name: "Title");
            DropIndex(table: "dbo.FixingIT.LanguageType", name: "Name");
            DropIndex(table: "dbo.FixingIT.SitePage", name: "Name");
            DropIndex("dbo.FixingIT.LinkComment", new[] { "UserLinkId" });
            DropIndex("dbo.FixingIT.LinkVote", new[] { "UserLinkID" });
            DropIndex("dbo.FixingIT.UserLink", new[] { "LanguageType_Name" });
            DropIndex("dbo.FixingIT.UserProfile", new[] { "UserTheme_ID" });
            DropForeignKey("dbo.FixingIT.LinkComment", "UserLinkId", "dbo.FixingIT.UserLink");
            DropForeignKey("dbo.FixingIT.LinkVote", "UserLinkID", "dbo.FixingIT.UserLink");
            DropForeignKey("dbo.FixingIT.UserLink", "LanguageType_Name", "dbo.FixingIT.LanguageType");
            DropForeignKey("dbo.FixingIT.UserProfile", "UserTheme_ID", "dbo.FixingIT.UserTheme");
            DropTable("dbo.FixingIT.LogOnViewModel");
            DropTable("dbo.FixingIT.RegisterExternalLoginModel");
            DropTable("dbo.FixingIT.UsersSkillLevel");
            DropTable("dbo.FixingIT.UserComment");
            DropTable("dbo.FixingIT.UserTheme");
            DropTable("dbo.FixingIT.SitePage");
            DropTable("dbo.FixingIT.LanguageType");
            DropTable("dbo.FixingIT.LinkComment");
            DropTable("dbo.FixingIT.LinkVote");
            DropTable("dbo.FixingIT.UserLink");
            DropTable("dbo.FixingIT.UserProfile");
        }
    }
}
