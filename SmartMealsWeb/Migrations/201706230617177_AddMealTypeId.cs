namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMealTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Meals", "MealPlanType_Id", "dbo.MealPlanTypes");
            DropIndex("dbo.Meals", new[] { "MealPlanType_Id" });
            AddColumn("dbo.Users", "MealPlanTypeID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Users", "MealPlanTypeID");
            AddForeignKey("dbo.Users", "MealPlanTypeID", "dbo.MealPlanTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Meals", "MealPlanType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Meals", "MealPlanType_Id", c => c.Byte());
            DropForeignKey("dbo.Users", "MealPlanTypeID", "dbo.MealPlanTypes");
            DropIndex("dbo.Users", new[] { "MealPlanTypeID" });
            DropColumn("dbo.Users", "MealPlanTypeID");
            CreateIndex("dbo.Meals", "MealPlanType_Id");
            AddForeignKey("dbo.Meals", "MealPlanType_Id", "dbo.MealPlanTypes", "Id");
        }
    }
}
