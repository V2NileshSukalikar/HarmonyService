using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class SiteDataBO
    {
        public GlobalDataBO g { get; set; }
        public List<FrequentDataBO> f { get; set; }
        public SpecificDataBO s { get; set; }
    }
}
