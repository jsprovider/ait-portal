using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class EndpointRoute
    {
        public int Id { get; set; }
        public int DatabaseId { get; set; }
        public int EndpointRouteTypeId { get; set; }
        public string Route { get; set; }
        public int? Port { get; set; }
        public string Protocol { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public Databases Database { get; set; }
        public EndpointRouteType EndpointRouteType { get; set; }
    }
}
