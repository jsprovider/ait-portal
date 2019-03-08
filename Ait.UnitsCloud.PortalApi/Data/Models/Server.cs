using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class Server
    {
        public Server()
        {
            Databases = new HashSet<Databases>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int? ServerTypeId { get; set; }
        public int? GatewayId { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public Company Company { get; set; }
        public Gateway Gateway { get; set; }
        public ServerType ServerType { get; set; }
        public ICollection<Databases> Databases { get; set; }
    }
}
