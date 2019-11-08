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
        public PhanTuNode pre;

        public PhanTuNode()
        {
            next = pre = null;
        }

        public PhanTuNode(PhanTu PT)
        {
            data = PT;
            next = pre = null;
        }
    }
}
