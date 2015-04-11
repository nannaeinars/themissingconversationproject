using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheMissingConversationProject.Models
{
    public class ConversationRepository
    {
        public static List<Conversation> GetConversations()
        {
            using (var dContext = new TheMissingConversationProjectContext())
            {
                return dContext.Conversations.ToList();
            }
        }

        public static void AddConversation(string firstPerson, string secondPerson)
        {

            using (var dContext = new TheMissingConversationProjectContext())
            {
                var conversation = new Conversation
                {
                    FirstPerson = firstPerson,
                    SecondPerson = secondPerson,
                    DateAdded = DateTime.Now
                };

                dContext.Conversations.Add(conversation);
                dContext.SaveChanges();
            }
        }
    }
}