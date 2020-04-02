namespace ZadanieConcrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTickets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.Int(nullable: false),
                        Event_EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .Index(t => t.Event_EventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Event_EventId", "dbo.Events");
            DropIndex("dbo.Tickets", new[] { "Event_EventId" });
            DropTable("dbo.Tickets");
        }
    }
}
