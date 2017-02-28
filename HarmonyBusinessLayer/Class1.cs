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
        public cmsData getCmsData(bool isheader )
        {
            return new cmsData(isheader);
        }

        



    }
}
