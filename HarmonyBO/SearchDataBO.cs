using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class SearchDataBO
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<SearchContentBO> data { get; set; }
    }
}
