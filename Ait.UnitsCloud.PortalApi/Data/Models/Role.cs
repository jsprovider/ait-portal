using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            UsersRole = new HashSet<UsersRole>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public ICollection<UsersRole> UsersRole { get; set; }
    }
}
