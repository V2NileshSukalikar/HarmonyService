using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class Commondata
    {
        public HeaderData HeaderData { get; set; }

        public List<MenuData> MenuListData { get; set; }

        public FooterData Footerdata { get; set; }

        public Commondata()
        {
            MenuListData = new List<MenuData>();
            HeaderData = new HeaderData();
            Footerdata = new FooterData();
        }

    }

    public class HeaderData
    {
        public string CompanyName { get; set; }

        public string Companylogo { get; set; }

        public HeaderData()
        {
            CompanyName = "";
            Companylogo = "";
        }


    }

    public class MenuData
    {
        public string MenuName { get; set; }

        public string MenuUrl { get; set; }

       


    }

    public class FooterData
    {
        public string copyrighttext { get; set; }

        public FooterData()
        {
            copyrighttext = "";
         
        }
    }
}
