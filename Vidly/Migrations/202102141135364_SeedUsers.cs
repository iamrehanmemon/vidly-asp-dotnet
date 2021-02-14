namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f1eecf4-a1aa-4d7c-8515-974598361a66', N'Guest@vidly.com', 0, N'APmhH60K5/Xiwk5CR+FefFgOReoGyZSg91CW8BOJQsRYx8ScRX9cuKNWQGmZJ8KMRw==', N'5b1b2142-d0e8-40ec-8710-dd2eda598d21', NULL, 0, 0, NULL, 1, 0, N'Guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f6eb5cf3-67d1-4942-a749-47b773c46d4f', N'Admin@vidly.com', 0, N'AEYmZNfg1/ji+yHkqfkrOSSf2maK1VFvp+o2J0pdCSpVSbu6M1g5URtA0mXlikAjCQ==', N'e6e37f2e-93ea-41df-a197-78c6e0831ec2', NULL, 0, 0, NULL, 1, 0, N'Admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'670290c1-d1eb-4d05-a17d-5c368ed3a31f', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f6eb5cf3-67d1-4942-a749-47b773c46d4f', N'670290c1-d1eb-4d05-a17d-5c368ed3a31f')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
