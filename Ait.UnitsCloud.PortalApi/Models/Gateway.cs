using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class Gateway
    {
        public Gateway()
        {
            Server = new HashSet<Server>();
        }

        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public string UnitsClientId { get; set; }

        public Company Company { get; set; }
        public ICollection<Server> Server { get; set; }
    }
}
