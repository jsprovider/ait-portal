using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class UsersRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public Role Role { get; set; }
    }
}
