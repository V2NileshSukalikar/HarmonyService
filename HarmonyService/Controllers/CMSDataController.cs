using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using HarmonyBusinessLayer;

namespace HarmonyService.Controllers
{
    public class CMSDataController : ApiController
    {
        // GET api/<controller>
        CmsDataservice objService = new CmsDataservice();
        public HttpResponseMessage GetcmsData(bool isheader)
        {
           
            var data =objService.getCmsData(isheader);
            return Request.CreateResponse(HttpStatusCode.OK, data );
        }

     
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}