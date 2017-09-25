namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameUserToFriend : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Friends");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Friends", newName: "Users");
        }
    }
}
