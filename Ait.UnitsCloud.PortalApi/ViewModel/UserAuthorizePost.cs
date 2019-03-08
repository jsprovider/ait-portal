using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class UserAuthorizePost
    {
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }     
        public int DatabaseId { get; set; }
        public string GrantType { get; set; }
        public string RefreshToken { get; set; }
        public string DeploymentTypeCode { get; set; } = "PROD"; //set default value to 1

        //public string Company { get; set; }
        ///// <summary>
        ///// This is public key relating to company, solution provider and solution
        ///// One company can be provided multiple software by the same provider with multiple public keys
        ///// </summary>
        //public string CompanypublicKey { get; set; }
        ///// <summary>
        ///// Gateway and company need to be resolved using databaseId
        ///// </summary>
    }

}