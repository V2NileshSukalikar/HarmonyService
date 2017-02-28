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
            MenuListData = new List<MenuData>() { new MenuData { MenuName = "menu1", MenuUrl = "//menu1" } };
            HeaderData = new HeaderData() { CompanyName = "Demo Company", Companylogo = "~\\Images\\V2-Solutions.jpg" };
            Footerdata = new FooterData() { copyrighttext = "This is copyright text" };
        }

    }

    public class HeaderData
    {
        public string CompanyName { get; set; }

        public string Companylogo { get; set; }
    }

    public class MenuData
    {
        public string MenuName { get; set; }

        public string MenuUrl { get; set; }



    }

    public class FooterData
    {
        public string copyrighttext { get; set; }
    }
}
