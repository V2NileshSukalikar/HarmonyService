using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class CMSData
    {
        public string PageName { get; set; }

        public Commondata GlobalData { get; set; }

        public PageSpecificData pagespecificData { get; set; }

        public CMSData()
        {

            GlobalData = new Commondata();


            pagespecificData = new PageSpecificData();
        }



    }


}
