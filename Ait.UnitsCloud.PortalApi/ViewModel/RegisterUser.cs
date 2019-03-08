using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class RegisterUser
    {
        [Required]
        public string UserName { get; set; }
        //[DataType(DataType.EmailAddress)]
        [Required]
        public string EmailAddress { get; set; }


        //[DataType(DataType.Password)]
        public string Password { get; set; }

        public bool EmailConfirmed { get; set; }

        public int CompanyID { get; set; }

        public int UserTypeId { get; set; }

    }
}