using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyBO
{
    public class pageSpecificData
    {
        public List<int> orientation { get; set; }

        public List<contentData> contetntData { get; set; }

       public pageSpecificData()
        {
            orientation = new List<int> { 2, 1, 3, 3 };
            contetntData = new List<contentData> { new contentData { type = "Html", data = "<h1>This is dummy data 1</h1>" },
                new contentData { type = "Html", data = "<h1>This is dummy data 2</h1>" }
            };

    }

    }

    public class contentData {

        public string type { get; set; }

        public string data { get; set; }
    }
}
