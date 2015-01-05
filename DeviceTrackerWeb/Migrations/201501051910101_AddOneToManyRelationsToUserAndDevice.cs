namespace DeviceTrackerWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOneToManyRelationsToUserAndDevice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Devices", "DTIdentityUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Devices", "DTIdentityUser_Id");
            AddForeignKey("dbo.Devices", "DTIdentityUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Devices", "DTIdentityUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Devices", new[] { "DTIdentityUser_Id" });
            DropColumn("dbo.Devices", "DTIdentityUser_Id");
        }
    }
}
