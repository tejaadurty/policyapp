using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using RestSharp;
using PolicyApp.Models;

namespace PolicyApp.Apicall
{
    public class Service
    {

        public string SaveUrl;
        public Service() {

            SaveUrl = "http://localhost:52863/Api/Policy/Save";

        }

        public IRestResponse savepolicy(Policy obj)
        {
            var client = new RestClient(SaveUrl);
            var request = new RestRequest(Method.POST);

            string jsonRequest = JsonConvert.SerializeObject(obj);
            request.AddParameter(
                              "application/json; charset=utf-8",
                              jsonRequest,
                              ParameterType.RequestBody);
            request.AddBody(jsonRequest);
            var response = client.Execute(request);
            return response;
        }

    }
}