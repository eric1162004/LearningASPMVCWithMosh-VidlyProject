namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'53913b9e-31ae-4056-8bb9-48f9df88505e', N'guest@vidly.com', 0, N'AAyRKIMKNJfLisDfT8mc6xBWqdZKdT6DmyCXFYHbxJaVoUyJhLpH6zMKxdjBTvklkg==', N'fd26ea67-27e0-4d82-a517-b1d26c678e71', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd9bfb3d3-66d3-49b8-a9bc-478fcfcf08ff', N'admin@vidly.com', 0, N'AAKfGR9GFr1ParDRvL3XLUTeC4zwagS05ZzCoX/eMr4KioQwPDbMHcTHwowYhxOz/Q==', N'73e7e650-5c63-4bd5-934e-36e235b24176', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1809aabf-670b-4e44-a2f1-e675fe818989', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd9bfb3d3-66d3-49b8-a9bc-478fcfcf08ff', N'1809aabf-670b-4e44-a2f1-e675fe818989')

");
        }
        
        public override void Down()
        {
        }
    }
}
