namespace SelfmanagmentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTasks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "TaskOneTargetOneValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskOneTargetTwoValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskOneTargetThreeValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskOneTargetWhyValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskTwoTargetOneValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskTwoTargetTwoValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskTwoTargetThreeValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskTwoTargetWhyValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskThreeTargetOneValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskThreeTargetTwoValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskThreeTargetThreeValue", c => c.String());
            AddColumn("dbo.Tasks", "TaskThreeTargetWhyValue", c => c.String());
            AddColumn("dbo.Tasks", "AwardValue", c => c.String());
            DropColumn("dbo.Tasks", "LearningValue");
            DropColumn("dbo.Tasks", "ThanksValue");
            DropColumn("dbo.Tasks", "UpValue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "UpValue", c => c.String());
            AddColumn("dbo.Tasks", "ThanksValue", c => c.String());
            AddColumn("dbo.Tasks", "LearningValue", c => c.String());
            DropColumn("dbo.Tasks", "AwardValue");
            DropColumn("dbo.Tasks", "TaskThreeTargetWhyValue");
            DropColumn("dbo.Tasks", "TaskThreeTargetThreeValue");
            DropColumn("dbo.Tasks", "TaskThreeTargetTwoValue");
            DropColumn("dbo.Tasks", "TaskThreeTargetOneValue");
            DropColumn("dbo.Tasks", "TaskTwoTargetWhyValue");
            DropColumn("dbo.Tasks", "TaskTwoTargetThreeValue");
            DropColumn("dbo.Tasks", "TaskTwoTargetTwoValue");
            DropColumn("dbo.Tasks", "TaskTwoTargetOneValue");
            DropColumn("dbo.Tasks", "TaskOneTargetWhyValue");
            DropColumn("dbo.Tasks", "TaskOneTargetThreeValue");
            DropColumn("dbo.Tasks", "TaskOneTargetTwoValue");
            DropColumn("dbo.Tasks", "TaskOneTargetOneValue");
        }
    }
}
