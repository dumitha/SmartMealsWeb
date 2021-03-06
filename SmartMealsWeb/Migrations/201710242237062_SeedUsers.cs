namespace SmartMealsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'167a2d1c-44ed-45c4-87a9-bb0a7c566b07', N'guest@smartmeals.com', 0, N'AFvuxvM+quLfNjxsY8ep5KAT22a9u9zfIG+z/xROiCpakWCxqXdbo9Ly7r3jx5Kg7A==', N'4c12f21e-bf96-465f-8385-93f296851f89', NULL, 0, 0, NULL, 1, 0, N'guest@smartmeals.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1b5db702-336d-4192-8b7d-3cd3924e2d82', N'admin@smartmeals.com', 0, N'AMWEPdpSfzEE/Oa2QoAh0ErFQsD6fJW5qoD82BjD1h/nibR+LYtj2cyT+KVe5WsDWg==', N'726572d6-95e7-4264-82b5-7b1dbc81e886', NULL, 0, 0, NULL, 1, 0, N'admin@smartmeals.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'716f91f6-9a92-4e34-a01b-83a9c2deaada', N'funnygirl_carrie22@hotmail.com', 0, N'AK44WzVMerkBFcn/6Pd3h6F/F/oS+It3z7uSTfpulp8MKiD+WnQMwcuHRufP+7AMAw==', N'960fa088-fc27-48d4-9450-7a7d84fd22cf', NULL, 0, 0, NULL, 1, 0, N'funnygirl_carrie22@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'975cfaa6-f0d0-4d32-88b9-ced13e88bf86', N'dumitha98@gmail.com', 0, N'AOSrAfS2okzBP6soBt5PUiw095nhtwZMTreunpY8neRv9EFsSf5SpvwAK726+NdIZA==', N'c526847c-5168-4b0b-b575-9f4f1b6eed89', NULL, 0, 0, NULL, 1, 0, N'dumitha98@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9bb40d2f-0bd9-4bdb-bf27-676e9fbd350c', N'dhcarrie@yahoo.com', 0, N'AKSza9GQUGJBp4/bnWQjZ9w6M+z3pyPykI0W5LSmwNFUaxmenzUtfr7TIBEvxEEyJg==', N'bc0cce89-2a03-427d-83b4-04bb40692636', NULL, 0, 0, NULL, 1, 0, N'dhcarrie@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd3913ab3-24a5-43a6-b6ad-2959c1072fc2', N'dhcarrie22@yahoo.com', 0, N'AOUTcTklCKT9o/44vcCNInwaClbjVzIIPjjv31U4aD1leKDOmmlu22GAH3lcT92W8w==', N'803325f4-0360-47a0-87d8-352ba8f1e173', NULL, 0, 0, NULL, 1, 0, N'dhcarrie22@yahoo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e5960835-75dd-42e8-9614-324c293dd157', N'CanManageMeals')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1b5db702-336d-4192-8b7d-3cd3924e2d82', N'e5960835-75dd-42e8-9614-324c293dd157')




"
                );
        }
        
        public override void Down()
        {
        }
    }
}
