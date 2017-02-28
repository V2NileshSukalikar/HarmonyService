using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class CMSData
    {
        public Commondata GlobalData { get; set; }

        public PageSpecificData pagespecificData { get; set; }

      public  CMSData(bool isheader )
        {
            if (isheader==true)
            {
                GlobalData = new Commondata();
            }

            pagespecificData = new PageSpecificData();
        }

        

    }

    
}
