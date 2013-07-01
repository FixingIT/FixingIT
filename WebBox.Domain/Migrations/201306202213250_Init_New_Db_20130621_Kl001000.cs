namespace WebBox.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_New_Db_20130621_Kl001000 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebBox.UserProfile",
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
                .ForeignKey("dbo.WebBox.UserTheme", t => t.UserTheme_ID)
                .Index(t => t.UserTheme_ID);
            
            CreateTable(
                "dbo.WebBox.UserLink",
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
                .ForeignKey("dbo.WebBox.LanguageType", t => t.LanguageType_Name)
                .Index(t => t.LanguageType_Name);
            
            CreateTable(
                "dbo.WebBox.LinkVote",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserLinkID = c.Int(nullable: false),
                        VotersID = c.Int(nullable: false),
                        VotersEmail = c.String(nullable: false),
                        Vote = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WebBox.UserLink", t => t.UserLinkID, cascadeDelete: true)
                .Index(t => t.UserLinkID);
            
            CreateTable(
                "dbo.WebBox.LinkComment",
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
                .ForeignKey("dbo.WebBox.UserLink", t => t.UserLinkId, cascadeDelete: true)
                .Index(t => t.UserLinkId);
            
            CreateTable(
                "dbo.WebBox.LanguageType",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 100),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.WebBox.SitePage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WebBox.UserTheme",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WebBox.UserComment",
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
                "dbo.WebBox.UsersSkillLevel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Level = c.String(),
                        Type = c.String(),
                        LogedInUsersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WebBox.RegisterExternalLoginModel",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        ExternalLoginData = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.WebBox.LogOnViewModel",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        RememberMe = c.Boolean(nullable: false),
                        EnablePasswordReset = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Email);

            CreateIndex(
                    table: "dbo.WebBox.UserProfile",
                    column: "Email",
                    unique: true);

            CreateIndex(
                    table: "dbo.WebBox.UserTheme",
                    column: "Name",
                    unique: true);

            CreateIndex(
                    table: "dbo.WebBox.UserLink",
                    column: "Title",
                    unique: true);

            CreateIndex(
                    table: "dbo.WebBox.LanguageType",
                    column: "Name",
                    unique: true);

            CreateIndex(
                    table: "dbo.WebBox.SitePage",
                    column: "Name",
                    unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex(table: "dbo.WebBox.UserProfile", name: "Email");
            DropIndex(table: "dbo.WebBox.UserThemes", name: "Name");
            DropIndex(table: "dbo.WebBox.UserLink", name: "Title");
            DropIndex(table: "dbo.WebBox.LanguageType", name: "Name");
            DropIndex(table: "dbo.WebBox.SitePage", name: "Name");
            DropIndex("dbo.WebBox.LinkComment", new[] { "UserLinkId" });
            DropIndex("dbo.WebBox.LinkVote", new[] { "UserLinkID" });
            DropIndex("dbo.WebBox.UserLink", new[] { "LanguageType_Name" });
            DropIndex("dbo.WebBox.UserProfile", new[] { "UserTheme_ID" });
            DropForeignKey("dbo.WebBox.LinkComment", "UserLinkId", "dbo.WebBox.UserLink");
            DropForeignKey("dbo.WebBox.LinkVote", "UserLinkID", "dbo.WebBox.UserLink");
            DropForeignKey("dbo.WebBox.UserLink", "LanguageType_Name", "dbo.WebBox.LanguageType");
            DropForeignKey("dbo.WebBox.UserProfile", "UserTheme_ID", "dbo.WebBox.UserTheme");
            DropTable("dbo.WebBox.LogOnViewModel");
            DropTable("dbo.WebBox.RegisterExternalLoginModel");
            DropTable("dbo.WebBox.UsersSkillLevel");
            DropTable("dbo.WebBox.UserComment");
            DropTable("dbo.WebBox.UserTheme");
            DropTable("dbo.WebBox.SitePage");
            DropTable("dbo.WebBox.LanguageType");
            DropTable("dbo.WebBox.LinkComment");
            DropTable("dbo.WebBox.LinkVote");
            DropTable("dbo.WebBox.UserLink");
            DropTable("dbo.WebBox.UserProfile");
        }
    }
}
