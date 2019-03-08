using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class CompanyInfo
    {
        public int Id { get; set; }
        public Nullable<int> Number { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
      
        public Nullable<int> StatusId { get; set; }
        

      //  public  List<ServersGateway> GatewayList { get; set; }
    }


    public class Company
    {
        public int Id { get; set; }
        public Nullable<int> Number { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public Nullable<int> StatusId { get; set; }
    }
}