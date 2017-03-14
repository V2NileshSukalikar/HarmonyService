using HarmonyBO;
using HarmonyBusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace HarmonyBusinessLayer.Repository
{
    public class HarmonyRepository : IHarmony
    {
        public List<HarmonyBO.SearchDataBO> GetFilteredRecords(string searchText)
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
            return null;
        }
    }
}
