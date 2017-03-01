using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class PageSpecificData
    {
        public List<int> orientation { get; set; }

        public List<ContentData> contetntData { get; set; }

        public bool isCacheble { get; set; }

        public PageSpecificData()
        {
            //orientation = new List<int> { 2, 1, 3, 3 };
            //contetntData = new List<ContentData> { new ContentData { type = "Html", data = "<h1>This is dummy data 1</h1>" },
            //    new ContentData { type = "Html", data = "<h1>This is dummy data 2</h1>" }
            //};
            //isCacheble = true;
            orientation = new List<int>();
            contetntData = new List<ContentData>();
       }

    }

    public class ContentData {

        public string type { get; set; }

        public string data { get; set; }

        
    }
}
