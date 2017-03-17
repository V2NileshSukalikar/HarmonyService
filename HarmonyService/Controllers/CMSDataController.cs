using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.IO;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using HarmonyBO;

namespace HarmonyService.Controllers
{
    public class CMSDataController : ApiController
    {
        #region Controllers

        public HttpResponseMessage GetCMSJsonData(string pagename, bool isheader)
        {
            int pageID = 1;
            if (int.TryParse(pagename, out pageID))
            {

            }
            string fileName = GetThePageById(pageID);

            string file = System.Web.HttpContext.Current.Server.MapPath(fileName);
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var siteData = ser.Deserialize<SiteDataBO>(Json);
            if (!isheader)
            {
                siteData.g = null;
            }
            return Request.CreateResponse(HttpStatusCode.OK, siteData);
        }

        [Route("api/GetFilteredRecords/{searchText}/{typeId:int}")]
        public HttpResponseMessage GetFilteredRecords(string searchText, int typeId)
        {
            //get the Json filepath  
            string file = System.Web.HttpContext.Current.Server.MapPath("~/Data/searchdata.json");
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var searchData = ser.Deserialize<SearchDataBO>(Json);
            switch (typeId)
            {
                //alpha search
                case 1:
                    if (searchData.data != null)
                    {
                        searchData.data = searchData.data.Where(c => c.ProviderName.StartsWith(searchText)).ToList();
                    }
                    break;
                //contains search
                case 2:
                    if (searchData.data != null)
                    {
                        searchData.data = searchData.data.Where(c => c.ProviderName.Contains(searchText)).ToList();
                    }
                    break;
                case 3:
                    if (searchData.data != null)
                    {
                        searchData.data = searchData.data.Where(c => c.ProviderName.Contains(searchText)).ToList();
                    }
                    break;
                default:
                    searchData.data = searchData.data;
                    break;
            }

            return Request.CreateResponse(HttpStatusCode.OK, searchData);
        }

        #endregion

        #region Methods

        private static string GetThePageById(int pageID)
        {
            //get the Json filepath  
            string fileName = "~/Data/Home.json";
            switch (pageID)
            {
                case 1:
                    fileName = "~/Data/SubPages/WhatsNewPage.json";
                    break;
                case 2:
                    fileName = "~/Data/SubPages/AdultAbuse.json";
                    break;
                case 3:
                    fileName = "~/Data/SubPages/Alzheimer.json";
                    break;
                case 4:
                    fileName = "~/Data/SubPages/Behavioral.json";
                    break;
                case 5:
                    fileName = "~/Data/SubPages/Emergency.json";
                    break;
                case 6:
                    fileName = "~/Data/SubPages/Everyday.json";
                    break;
                case 7:
                    fileName = "~/Data/SubPages/Financial.json";
                    break;
                case 8:
                    fileName = "~/Data/SubPages/Healthcare.json";
                    break;
                case 9:
                    fileName = "~/Data/SubPages/Home.json";
                    break;
                case 10:
                    fileName = "~/Data/SubPages/Information.json";
                    break;
                case 11:
                    fileName = "~/Data/SubPages/Intellectual.json";
                    break;
                case 12:
                    fileName = "~/Data/SubPages/Legal.json";
                    break;
                case 13:
                    fileName = "~/Data/SubPages/Senior.json";
                    break;
                case 14:
                    fileName = "~/Data/SubPages/Support.json";
                    break;
                case 15:
                    fileName = "~/Data/SubPages/Veterans.json";
                    break;
                case 16:
                    fileName = "~/Data/SubPages/WhatsNewPage.json";
                    break;
                case 2079:
                    fileName = "~/Data/Home.json";
                    break;
                case 2080:
                    fileName = "~/Data/AboutUs.json";
                    break;
                case 2081:
                    fileName = "~/Data/KnowledgeCenter.json";
                    break;
                case 2082:
                    fileName = "~/Data/HowToUseSite.json";
                    break;
                default:
                    fileName = "~/Data/Home.json";
                    break;
            }
            return fileName;
        }

        #endregion

    }
}