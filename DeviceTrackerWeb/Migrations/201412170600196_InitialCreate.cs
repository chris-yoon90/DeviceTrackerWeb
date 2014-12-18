namespace DeviceTrackerWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DeviceId = c.String(nullable: false, maxLength: 50),
                        Model = c.String(nullable: false, maxLength: 50),
                        Made = c.String(nullable: false, maxLength: 50),
                        OS = c.String(nullable: false, maxLength: 50),
                        ScreenSize = c.String(nullable: false, maxLength: 50),
                        User = c.String(maxLength: 50),
                        CheckOutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Devices");
        }
    }
}
