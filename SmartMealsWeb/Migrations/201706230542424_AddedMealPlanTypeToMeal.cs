namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMealPlanTypeToMeal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MealPlanTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        DurationInMonths = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Meals", "MealPlanType_Id", c => c.Byte());
            CreateIndex("dbo.Meals", "MealPlanType_Id");
            AddForeignKey("dbo.Meals", "MealPlanType_Id", "dbo.MealPlanTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meals", "MealPlanType_Id", "dbo.MealPlanTypes");
            DropIndex("dbo.Meals", new[] { "MealPlanType_Id" });
            DropColumn("dbo.Meals", "MealPlanType_Id");
            DropTable("dbo.MealPlanTypes");
        }
    }
}
