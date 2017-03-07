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
using System.Web.Script.Serialization;
using HarmonyBO;

namespace HarmonyService.Controllers
{
    public class CMSDataController : ApiController
    {
        // GET api/<controller>
        CmsDataservice objService = new CmsDataservice();

        public HttpResponseMessage GetcmsData(string pagename, bool isheader)
        {
            var data = objService.getCmsData(pagename, isheader);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        public HttpResponseMessage GetCMSJsonData(string pagename, bool isheader)
        {
            int pageID = 1;
            if (int.TryParse(pagename, out pageID))
            {

            }
            //get the Json filepath  
            string fileName = pageID == 2079 ? "~/Data/page1.json" : pageID == 2080 ? "~/Data/page2.json" : "~/Data/page3.json";

            string file = System.Web.HttpContext.Current.Server.MapPath(fileName);
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var siteData = ser.Deserialize<SiteDataBO>(Json);
            return Request.CreateResponse(HttpStatusCode.OK, siteData);
        }

        public HttpResponseMessage GetFilteredRecords(string searchText)
        {
            //get the Json filepath  
            string file = System.Web.HttpContext.Current.Server.MapPath("~/Data/searchdata.json");
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var searchData = ser.Deserialize<SearchDataBO>(Json);
            if (searchData.data != null)
            {
                searchData.data = searchData.data.Where(c => c.ProviderName.Contains(searchText)).ToList();
            }
            return Request.CreateResponse(HttpStatusCode.OK, searchData);
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