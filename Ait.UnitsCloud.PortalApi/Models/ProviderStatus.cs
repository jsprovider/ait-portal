using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class ProviderStatus
    {
        public ProviderStatus()
        {
            Provider = new HashSet<Provider>();
        }

        public int Id { get; set; }
        public int? ListOrder { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public ICollection<Provider> Provider { get; set; }
    }
}
