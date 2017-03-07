using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarmonyBO
{
    public class FrequentDataBO
    {
        public int Oid { get; set; }
        public int Site { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Logo { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public bool IsAuth { get; set; }
        public bool IsMenu { get; set; }
    }
}
