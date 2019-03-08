using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class EmailRecipient
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string AddressReplyTo { get; set; }
        public string AddressTo { get; set; }

        public EmailMessage Message { get; set; }
    }
}
