using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class EmailConversation
    {
        public EmailConversation()
        {
            EmailMessage = new HashSet<EmailMessage>();
        }

        public int Id { get; set; }

        public ICollection<EmailMessage> EmailMessage { get; set; }
    }
}
