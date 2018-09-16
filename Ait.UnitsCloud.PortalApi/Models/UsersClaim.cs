using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class UsersClaim
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
