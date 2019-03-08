using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class ProviderCompany
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? CompanyId { get; set; }
        public string PublicKey { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public string Hash { get; set; }

        public Company Company { get; set; }
        public Provider Provider { get; set; }
    }
}
