namespace SelfmanagmentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListDeals",
                c => new
                    {
                        ListDealID = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ListDealID);
            
            CreateTable(
                "dbo.PlaningUsers",
                c => new
                    {
                        PlaningUserID = c.Int(nullable: false, identity: true),
                        NamePlaning = c.String(),
                        TimePlaning = c.String(),
                        StatusPlaning = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlaningUserID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        TaskOneValue = c.String(),
                        TaskTwoValue = c.String(),
                        TaskThreeValue = c.String(),
                        LearningValue = c.String(),
                        ThanksValue = c.String(),
                        UpValue = c.String(),
                    })
                .PrimaryKey(t => t.TaskID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Hashpass = c.String(),
                        Email = c.String(),
                        Avatar = c.Binary(),
                        Task_TaskID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Tasks", t => t.Task_TaskID)
                .Index(t => t.Task_TaskID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Task_TaskID", "dbo.Tasks");
            DropIndex("dbo.Users", new[] { "Task_TaskID" });
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.PlaningUsers");
            DropTable("dbo.ListDeals");
        }
    }
}
