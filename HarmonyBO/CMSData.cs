using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class cmsData
    {
        public Commondata HeaderData { get; set; }

        public pageSpecificData pagespecificData { get; set; }

      public  cmsData()
        {
            HeaderData = new Commondata();

            pagespecificData = new pageSpecificData();
        }

    }

    
}
