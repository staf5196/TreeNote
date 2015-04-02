using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreebookC
{
    class Pagedata
    {
        public Pagedata()
        {
            text = "";
            isHeader = false;
            isLocked = false;
        }
        public string text;
        public bool isHeader;
        public bool isLocked;
        //Put other attributes here
    }
}
