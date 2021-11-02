using PolicyApp.Apicall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PolicyApp.Models;
using Newtonsoft.Json;

namespace PolicyApp.Controllers
{
    public class PolicytController : Controller
    {
        // GET: Policyt


        Service consume = new Service();
        [HttpGet]       
        public ActionResult Index()
        {
            
            ViewBag.policylist = plist(); 
           
            return View();
        }
        [HttpPost]      
        public ActionResult Index(Policy obj)
        {
           
            try
            {
          
                ViewBag.policylist = plist();

                var response = consume.savepolicy(obj);              
                
                List<Policy> Products = JsonConvert.DeserializeObject<List<Policy>>(response.Content);
                ViewBag.returndata= Products;
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('Sorry, Something Went Wrong...!');window.location ='/Policyt/Index';</script>");
            }

            return View();
        }

        public List<SelectListItem> plist() {
            List<SelectListItem> policylist = new List<SelectListItem>()
            {

                new SelectListItem { Text = "Personal Auto", Value = "PA" },
                new SelectListItem { Text = "Home Owners", Value = "HO" },
                new SelectListItem { Text = "Business Owners", Value = "BO" }

            };
            return policylist;

        }
    }
}