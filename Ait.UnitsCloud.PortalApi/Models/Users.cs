using System;
using System.Collections.Generic;

namespace Ait.UnitsCloud.PortalApi.Models
{
    public partial class Users
    {
        public Users()
        {
            InverseCreateUser = new HashSet<Users>();
            InverseUpdateUser = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? UserTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecurityStamp { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public bool? LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? UpdateUserId { get; set; }

        public Company Company { get; set; }
        public Users CreateUser { get; set; }
        public Users UpdateUser { get; set; }
        public UsersType UserType { get; set; }
        public ICollection<Users> InverseCreateUser { get; set; }
        public ICollection<Users> InverseUpdateUser { get; set; }
    }
}
