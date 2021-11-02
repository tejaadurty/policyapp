using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Policyservice.Models
{
    public class BusinessObjects
    {
    }

    public class Policy
    {
        public string policyno { get; set; }
        public string Policytype { get; set; }
        public string PersonName { get; set; }
        public string Address { get; set; }
        public string Risktype { get; set; }
        public string city { get; set; }


    }
}