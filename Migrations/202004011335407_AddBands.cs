namespace ZadanieConcrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBands : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        BandId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BandId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bands");
        }
    }
}
