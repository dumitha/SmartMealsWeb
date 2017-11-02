namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumberToApplication : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "GoalSetting_Id", "dbo.GoalSettings");
            DropIndex("dbo.AspNetUsers", new[] { "GoalSetting_Id" });
            AddColumn("dbo.AspNetUsers", "IsCompetingWithOtherUsers", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "PhoneNumberFriend", c => c.String());
            DropColumn("dbo.AspNetUsers", "GoalSetting_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "GoalSetting_Id", c => c.Byte());
            DropColumn("dbo.AspNetUsers", "PhoneNumberFriend");
            DropColumn("dbo.AspNetUsers", "IsCompetingWithOtherUsers");
            CreateIndex("dbo.AspNetUsers", "GoalSetting_Id");
            AddForeignKey("dbo.AspNetUsers", "GoalSetting_Id", "dbo.GoalSettings", "Id");
        }
    }
}
