using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class SystemAttributeResponse
    {
       public SystemAttribute[] Attributes;
        public string DatabaseEnvironment { get; set; }
        public string ViewCode { get; set; }

    }
    public class SystemAttribute
    {
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public string fieldCode { get; set; }

    }
}