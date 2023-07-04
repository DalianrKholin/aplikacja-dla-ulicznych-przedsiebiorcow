namespace aplikacja_dla_ulicznych_przedsiębiorców.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        item = c.String(maxLength: 500),
                        recipient_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.data", t => t.recipient_ID)
                .Index(t => t.recipient_ID);
            
            CreateTable(
                "dbo.data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        pass = c.String(),
                        adminPass = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "recipient_ID", "dbo.data");
            DropIndex("dbo.Messages", new[] { "recipient_ID" });
            DropTable("dbo.data");
            DropTable("dbo.Messages");
        }
    }
}
