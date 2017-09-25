namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MealType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MealTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Meals", "MealTypeID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Meals", "MealTypeID");
            AddForeignKey("dbo.Meals", "MealTypeID", "dbo.MealTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Meals", "DatePosted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Meals", "DatePosted", c => c.DateTime());
            DropForeignKey("dbo.Meals", "MealTypeID", "dbo.MealTypes");
            DropIndex("dbo.Meals", new[] { "MealTypeID" });
            DropColumn("dbo.Meals", "MealTypeID");
            DropTable("dbo.MealTypes");
        }
    }
}
