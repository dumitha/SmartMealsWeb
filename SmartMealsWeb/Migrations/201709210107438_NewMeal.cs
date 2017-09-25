namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMeal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Meals", "DatePosted", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Meals", "DatePosted");
        }
    }
}
