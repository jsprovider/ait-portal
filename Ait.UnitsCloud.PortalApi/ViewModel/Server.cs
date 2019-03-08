using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class Server
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public int? GateWayId { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
    }
}