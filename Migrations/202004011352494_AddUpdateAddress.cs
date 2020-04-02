namespace ZadanieConcrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdateAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "City_CityId", c => c.Int());
            CreateIndex("dbo.Addresses", "City_CityId");
            AddForeignKey("dbo.Addresses", "City_CityId", "dbo.Cities", "CityId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "City_CityId", "dbo.Cities");
            DropIndex("dbo.Addresses", new[] { "City_CityId" });
            DropColumn("dbo.Addresses", "City_CityId");
        }
    }
}
