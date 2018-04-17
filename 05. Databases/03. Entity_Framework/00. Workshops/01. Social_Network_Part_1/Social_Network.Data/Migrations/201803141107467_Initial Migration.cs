namespace Social_Network.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friendships",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstUserID = c.Int(nullable: false),
                        SecondUserID = c.Int(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        FriendsSince = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserProfiles", t => t.FirstUserID)
                .ForeignKey("dbo.UserProfiles", t => t.SecondUserID)
                .Index(t => t.FirstUserID)
                .Index(t => t.SecondUserID);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        RegisteredOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(nullable: false),
                        FileExtension = c.String(nullable: false, maxLength: 4),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserProfiles", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AuthorID = c.Int(nullable: false),
                        Content = c.String(nullable: false),
                        SentOn = c.DateTime(nullable: false),
                        SeenOn = c.DateTime(),
                        Friendship_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserProfiles", t => t.AuthorID)
                .ForeignKey("dbo.Friendships", t => t.Friendship_ID)
                .Index(t => t.AuthorID)
                .Index(t => t.Friendship_ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 10),
                        PostedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostUserProfiles",
                c => new
                    {
                        Post_ID = c.Int(nullable: false),
                        UserProfile_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_ID, t.UserProfile_ID })
                .ForeignKey("dbo.Posts", t => t.Post_ID)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_ID)
                .Index(t => t.Post_ID)
                .Index(t => t.UserProfile_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friendships", "SecondUserID", "dbo.UserProfiles");
            DropForeignKey("dbo.Messages", "Friendship_ID", "dbo.Friendships");
            DropForeignKey("dbo.Friendships", "FirstUserID", "dbo.UserProfiles");
            DropForeignKey("dbo.PostUserProfiles", "UserProfile_ID", "dbo.UserProfiles");
            DropForeignKey("dbo.PostUserProfiles", "Post_ID", "dbo.Posts");
            DropForeignKey("dbo.Messages", "AuthorID", "dbo.UserProfiles");
            DropForeignKey("dbo.Images", "UserID", "dbo.UserProfiles");
            DropIndex("dbo.PostUserProfiles", new[] { "UserProfile_ID" });
            DropIndex("dbo.PostUserProfiles", new[] { "Post_ID" });
            DropIndex("dbo.Messages", new[] { "Friendship_ID" });
            DropIndex("dbo.Messages", new[] { "AuthorID" });
            DropIndex("dbo.Images", new[] { "UserID" });
            DropIndex("dbo.UserProfiles", new[] { "Username" });
            DropIndex("dbo.Friendships", new[] { "SecondUserID" });
            DropIndex("dbo.Friendships", new[] { "FirstUserID" });
            DropTable("dbo.PostUserProfiles");
            DropTable("dbo.Posts");
            DropTable("dbo.Messages");
            DropTable("dbo.Images");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Friendships");
        }
    }
}
