﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarmonyBO
{
    public class SpecificDataBO
    {
        public string Orientation { get; set; }
        public bool isCacheble { get; set; }
        public List<PageSpecificDataBO>  Data { get; set; }
    }
}
