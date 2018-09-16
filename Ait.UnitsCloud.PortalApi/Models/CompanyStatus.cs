using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class CompanyStatus
    {
        public CompanyStatus()
        {
            Company = new HashSet<Company>();
        }

        public int Id { get; set; }
        public int? ListOrder { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public ICollection<Company> Company { get; set; }
    }
}
