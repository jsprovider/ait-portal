using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class CompanyDatabases
    {
        public int DbId { get; set; }
        public int DbServerId { get; set; }
        public string DbDisplayName { get; set; }
        public string DbAlias { get; set; }

        public int? DbServerGatewayId { get; set; }
    }

    public class ProviderCompanyDatabasesPub
    {
        public DatabasePub Database { get; set; }
        
        public EndpointPub Endpoint { get; set; }
       
        public GatewayPub Gateway { get; set; }

        public ServerPub Server { get; set; }
    }

    public class DatabasePub
    {
        public string Alias { get; set; }
        public string DisplayName { get; set; }
    }

    public class EndpointPub
    {
        public Nullable<int> Port { get; set; }
        public string Protocol { get; set; }
        public string Route { get; set; }
        public string Routetype { get; set; }
    }

    public class GatewayPub
    {
        public string Description { get; set; }
        public string IpAddress { get; set; }
    }

    public class ServerPub
    {
        public string IpAddress { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

}