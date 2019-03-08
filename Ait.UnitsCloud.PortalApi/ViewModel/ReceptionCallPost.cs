using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ait.UnitsCloud.PortalApi.ViewModel
{
    public class ReceptionCallPost
    {
        public int CallNumber { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "No enquiry type presented")]
        public string enquiryType { get; set; }
        public string actionTaken { get; set; }
        public string source { get; set; }
        public string callBackMethod { get; set; }
        [Required(ErrorMessage = "No call status presented")]
        public string callStatus { get; set; }
        [Required(ErrorMessage = "No location presented")]
        public string location { get; set; }
        public string note { get; set; }
        public string referTo { get; set; }
        public string contactCode { get; set; }
        public string prospectCode { get; set; }
    }
}