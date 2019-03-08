using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class Databases
    {
        public Databases()
        {
            EndpointRoute = new HashSet<EndpointRoute>();
        }

        public int Id { get; set; }
        public int ServerId { get; set; }
        public string DisplayName { get; set; }
        public string Alias { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public string OdbcName { get; set; }

        public Server Server { get; set; }
        public ICollection<EndpointRoute> EndpointRoute { get; set; }
    }
}
