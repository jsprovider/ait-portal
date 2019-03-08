using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class ServerType
    {
        public ServerType()
        {
            Server = new HashSet<Server>();
        }

        public int Id { get; set; }
        public int? ListOrder { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public ICollection<Server> Server { get; set; }
    }
}
