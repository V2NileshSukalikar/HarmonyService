using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
   public class Commondata
    {
        public headerdata HeaderData { get; set; }

        public List<menudata> MenuListData { get; set; }

        public footerdata Footerdata { get; set; }
    public    Commondata()
        {
            MenuListData = new List<menudata>() { new menudata { MenuName = "menu1", MenuUr = "//menu1" } };
            HeaderData = new headerdata() { CompanyName = "Demo Company", Companylogo = "~\\Images\\V2-Solutions.jpg" };
            Footerdata = new footerdata() { copyrighttext = "This is copy right text" };
        }

    }

    public class headerdata
    {
        public string CompanyName { get; set; }

        public string Companylogo { get; set; }
    }

    public class menudata
    {
        public string MenuName { get; set; }

        public string MenuUr { get; set; }



    }

    public class footerdata
    {
        public string copyrighttext { get; set; }
    }  
}
