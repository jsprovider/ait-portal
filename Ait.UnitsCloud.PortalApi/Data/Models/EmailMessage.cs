using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class EmailMessage
    {
        public EmailMessage()
        {
            EmailRecipient = new HashSet<EmailRecipient>();
        }

        public int Id { get; set; }
        public int ConversationId { get; set; }
        public string AddressFrom { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }

        public EmailConversation Conversation { get; set; }
        public ICollection<EmailRecipient> EmailRecipient { get; set; }
    }
}
