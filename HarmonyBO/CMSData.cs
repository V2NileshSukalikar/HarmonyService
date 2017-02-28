using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class cmsData
    {
        public Commondata GlobalData { get; set; }

        public pageSpecificData pagespecificData { get; set; }

      public  cmsData(bool isheader )
        {
            if (isheader==true)
            {
                GlobalData = new Commondata();
            }

            pagespecificData = new pageSpecificData();
        }

        

    }

    
}
