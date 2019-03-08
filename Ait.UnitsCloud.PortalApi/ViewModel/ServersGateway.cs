using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class ServersGateway
    {
        public int GatewayId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string GatewayDescription { get; set; }
        public string GatewayIpAddress { get; set; }

    }
}