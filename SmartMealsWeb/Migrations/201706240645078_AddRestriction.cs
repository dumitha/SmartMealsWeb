namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestriction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Friends", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Friends", "Name", c => c.String());
        }
    }
}
