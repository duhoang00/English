using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class ArrayChuCai
    {
        ListPhanTu[] ChuCaiDau;

        public ArrayChuCai()
        {
            ChuCaiDau = new ListPhanTu[26];
        }

        public void taoDS()
        {
            for (int i = 0; i < 26; i++)
            {
                ChuCaiDau[i] = new ListPhanTu();
            }
        }

        public void docDS()
        {

        }
    }
}
