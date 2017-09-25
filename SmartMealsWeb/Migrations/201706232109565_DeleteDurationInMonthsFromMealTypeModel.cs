namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDurationInMonthsFromMealTypeModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MealPlanTypes", "DurationInMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MealPlanTypes", "DurationInMonths", c => c.Byte(nullable: false));
        }
    }
}
