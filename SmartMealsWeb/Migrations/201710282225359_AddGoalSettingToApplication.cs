namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGoalSettingToApplication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoalSettings",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "GoalSetting_Id", c => c.Byte());
            CreateIndex("dbo.AspNetUsers", "GoalSetting_Id");
            AddForeignKey("dbo.AspNetUsers", "GoalSetting_Id", "dbo.GoalSettings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "GoalSetting_Id", "dbo.GoalSettings");
            DropIndex("dbo.AspNetUsers", new[] { "GoalSetting_Id" });
            DropColumn("dbo.AspNetUsers", "GoalSetting_Id");
            DropTable("dbo.GoalSettings");
        }
    }
}
