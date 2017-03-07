using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
   public class PageSpecificDataBO
    {
        public string Type { get; set; }
        public int Orientation { get; set; }
        public int Search { get; set; }
        public List<ContentSpecificDataBO> Data { get; set; }
        public int Oid { get; set; }
        public int Views { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool IsActive { get; set; }
        public int? Sequence { get; set; }
    }

    public class ContentSpecificDataBO
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Title { get; set; }
    }
}
