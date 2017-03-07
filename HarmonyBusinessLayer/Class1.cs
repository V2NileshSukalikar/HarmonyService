using HarmonyBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBusinessLayer
{
    public class CmsDataservice
    {
       
        bool iscashe = false;
        public CmsDataservice()
        {
          


        }

        public CMSData getCmsData(string pagename , bool isheader )
        {

          var data =   getAll(isheader);

          var result = data.FirstOrDefault(t => t.PageName == pagename);

            return result;
        }

        private List<CMSData> getAll(bool isheader)
        {
            List<CMSData> lstPages = new List<CMSData>();
            for (int i = 1; i <= 5; i++)
            {
                CMSData pagedata = new CMSData();
                pagedata.PageName = "Page" + i;
                if (isheader == true)
                {


                    pagedata.GlobalData.HeaderData.Companylogo = "http://localhost:53142/Images/V2-Solutions.jpg";
                    pagedata.GlobalData.HeaderData.CompanyName = "Company-" + i;

                    for(int j=1; j<=5;j++)
                    pagedata.GlobalData.MenuListData.Add(new MenuData { MenuName = "Page" + j, MenuUrl = "/page/Page" + j });

                    pagedata.GlobalData.Footerdata.copyrighttext = "This is copyright Footer";
                }
                else
                {
                    pagedata.GlobalData = null;
                }
            

                pagedata.pagespecificData.orientation = new List<int> { (1 + i), (3 + i), (1 + i), 2 };

                for(var z=1;z<= ((i*4)  +7);z++)
                pagedata.pagespecificData.contetntData.Add( new ContentData { type = "Html", data = "<h1>This is dummy data of section " + z + "</h1>" } );

                pagedata.pagespecificData.isCacheble = !iscashe;
                iscashe = !iscashe;

                lstPages.Add(pagedata);
            }

            return lstPages;
        }
        



    }
}
