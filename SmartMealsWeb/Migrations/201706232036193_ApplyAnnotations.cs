namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsCompetingWithOtherUsers", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.Meals", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Meals", "Name", c => c.String());
            DropColumn("dbo.Users", "Birthdate");
            DropColumn("dbo.Users", "IsCompetingWithOtherUsers");
        }
    }
}
