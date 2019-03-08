using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class EndpointRouteType
    {
        public EndpointRouteType()
        {
            EndpointRoute = new HashSet<EndpointRoute>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public ICollection<EndpointRoute> EndpointRoute { get; set; }
    }
}
