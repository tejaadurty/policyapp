using Policyservice.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Policyservice.Controllers
{
    public class PolicyController : ApiController
    {
       

        [HttpPost]
        [Route("Api/Policy/Save")]
        public HttpResponseMessage Save(Policy objp)
        {
            try
            {
                DataAccess da = new DataAccess();
                var statusresult = "";
                if (objp.policyno != "")
                {
                    var result = da.savepolicy(objp);
                    if (result.Count != 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK,  result);

                    }
                    else
                    {
                        statusresult = "No data found";
                        return Request.CreateResponse(HttpStatusCode.OK, new { msgText = statusresult });
                    }
                }
                else
                {
                    statusresult = "Invalid policy number";

                    return Request.CreateResponse(HttpStatusCode.OK, new { msgText = statusresult });
                }


            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { msgText = ex.Message });
            }


        }
    }
}
