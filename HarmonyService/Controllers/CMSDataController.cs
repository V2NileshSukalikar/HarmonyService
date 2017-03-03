using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using HarmonyBusinessLayer;
using System.Text;
using System.IO;
using System.Net.Http.Headers;

namespace HarmonyService.Controllers
{
    public class CMSDataController : ApiController
    {
        // GET api/<controller>
        CmsDataservice objService = new CmsDataservice();

        //[Route("GetcmsData/{pagename}/{isheader}")]
        public HttpResponseMessage GetcmsData(string pagename, bool isheader)
        {
            var data = objService.getCmsData(pagename, isheader);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        public HttpResponseMessage GetCMSJsonData()
        {
            var file = System.Web.HttpContext.Current.Server.MapPath("~/Data/data.json");

            var stream = new FileStream(file, FileMode.Open);

            var result = Request.CreateResponse(HttpStatusCode.OK);
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return result;
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