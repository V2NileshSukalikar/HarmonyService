using HarmonyBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBusinessLayer.Services
{
    interface IHarmony
    {
        List<SearchDataBO> GetFilteredRecords(string searchText);
    }
}
