using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class PhanTuNode
    {       
        public PhanTu data;
        public PhanTuNode next;

        public PhanTuNode()
        {
            next = null;
        }

        public PhanTuNode(PhanTu PT)
        {
            data = PT;
            next = null;
        }
    }
}
