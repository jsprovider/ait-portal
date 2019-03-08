using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class RefreshToken
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string Subject { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
        public string ProtectedTicket { get; set; }
        public string Token { get; set; }

        public Company Company { get; set; }
    }
}
