using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Policyservice.Models
{
    public class DataAccess
    {


        public List<Policy> savepolicy(Policy objp) {

            List<Policy> lp = new List<Policy>();

            lp.Add(objp);

            return lp;

        }


    }


}