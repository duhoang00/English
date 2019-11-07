using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class Node
    {
        public PhanTu data;
        public Node next;

        public void taoNode(PhanTu x)
        {
            data = x;
            next = null;
        }
    }
}
