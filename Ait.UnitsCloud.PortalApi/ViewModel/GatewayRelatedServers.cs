using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class GatewayRelatedServers
    {
        public int GatewayId { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }

        public List<Server> GatewayRelatedServerList { get; set; }

    }
}