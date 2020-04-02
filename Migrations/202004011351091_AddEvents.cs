namespace ZadanieConcrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEvents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Band_BandId = c.Int(),
                        City_CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.Bands", t => t.Band_BandId)
                .ForeignKey("dbo.Cities", t => t.City_CityId, cascadeDelete: true)
                .Index(t => t.Band_BandId)
                .Index(t => t.City_CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Events", "Band_BandId", "dbo.Bands");
            DropIndex("dbo.Events", new[] { "City_CityId" });
            DropIndex("dbo.Events", new[] { "Band_BandId" });
            DropTable("dbo.Events");
        }
    }
}
