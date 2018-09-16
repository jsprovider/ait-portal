using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class Company
    {
        public Company()
        {
            Gateway = new HashSet<Gateway>();
            ProviderCompany = new HashSet<ProviderCompany>();
            RefreshToken = new HashSet<RefreshToken>();
            Server = new HashSet<Server>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int? Number { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string ArContactCodeEx { get; set; }
        public int? ArNumberEx { get; set; }
        public int? CompanyStatusId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public string PrivateKey { get; set; }

        public CompanyStatus CompanyStatus { get; set; }
        public ICollection<Gateway> Gateway { get; set; }
        public ICollection<ProviderCompany> ProviderCompany { get; set; }
        public ICollection<RefreshToken> RefreshToken { get; set; }
        public ICollection<Server> Server { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
