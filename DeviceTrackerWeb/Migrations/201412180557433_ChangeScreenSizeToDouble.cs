namespace DeviceTrackerWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeScreenSizeToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Devices", "ScreenSize", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Devices", "ScreenSize", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
