using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class ProviderIpRange
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string IpRange { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public Provider Provider { get; set; }
    }
}
