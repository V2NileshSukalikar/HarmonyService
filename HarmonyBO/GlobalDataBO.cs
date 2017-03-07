using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarmonyBO
{
    public class GlobalDataBO
    {
        public int Oid { get; set; }
        public string Name { get; set; }
        public string url { get; set; }
        public string Logo { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public List<MenuBO> Menu { get; set; }
    }

    public class MenuBO
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
