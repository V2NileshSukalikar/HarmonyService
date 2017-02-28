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
        public CMSData getCmsData(bool isheader )
        {
            return new CMSData(isheader);
        }

        



    }
}
