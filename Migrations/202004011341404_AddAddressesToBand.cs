namespace ZadanieConcrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressesToBand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        BandId = c.Int(nullable: false),
                        Street = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.BandId)
                .ForeignKey("dbo.Bands", t => t.BandId)
                .Index(t => t.BandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "BandId", "dbo.Bands");
            DropIndex("dbo.Addresses", new[] { "BandId" });
            DropTable("dbo.Addresses");
        }
    }
}
