using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheMissingConversationProject.Models
{
    public class Conversation
    {
        public int ConversationId { get; set; }
        public string FirstPerson { get; set; }
        public string SecondPerson { get; set; }
        public DateTime DateAdded { get; set; }
    }
}