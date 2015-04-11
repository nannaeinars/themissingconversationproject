namespace TheMissingConversationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conversations",
                c => new
                    {
                        ConversationId = c.Int(nullable: false, identity: true),
                        FirstPerson = c.String(),
                        SecondPerson = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ConversationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Conversations");
        }
    }
}
