using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class Provider
    {
        public Provider()
        {
            ProviderCompany = new HashSet<ProviderCompany>();
            ProviderIpRange = new HashSet<ProviderIpRange>();
        }

        public int Id { get; set; }
        public int? Number { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string ContactPerson { get; set; }
        public string ArContactCodeEx { get; set; }
        public int? ArNumberEx { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string MobilePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string Notes { get; set; }
        public int? Status { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public string PrivateKey { get; set; }

        public ProviderStatus StatusNavigation { get; set; }
        public ICollection<ProviderCompany> ProviderCompany { get; set; }
        public ICollection<ProviderIpRange> ProviderIpRange { get; set; }
    }
}
