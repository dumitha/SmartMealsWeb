namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTypeInMeal : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Meals", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Meals", "Type", c => c.String());
        }
    }
}
