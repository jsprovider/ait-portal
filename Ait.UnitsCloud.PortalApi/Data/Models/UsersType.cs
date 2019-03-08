using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Data.Models
{
    public partial class UsersType
    {
        public UsersType()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int? ListOrder { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
