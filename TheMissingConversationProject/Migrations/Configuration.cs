namespace TheMissingConversationProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TheMissingConversationProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TheMissingConversationProject.Models.TheMissingConversationProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheMissingConversationProject.Models.TheMissingConversationProjectContext context)
        {
            context.Conversations.AddOrUpdate(a => a.ConversationId,
                new Conversation
                {
                    FirstPerson = "Nanna",
                    SecondPerson = "Maggi",
                    DateAdded = DateTime.Now
                }
            );
        }
    }
}
