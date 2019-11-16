using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class PhanTu
    {
        public String Word;
        public String WordMeaning;
        public String WordType;
        public String WordExample;
        public string Status;

        public PhanTu()
        {
            Word = "";
            WordMeaning = "";
            WordType = "";
            WordExample = "";
            Status = "";
        }

        public PhanTu(String Tu, String Nghia, String LoaiTu, String ViDu,string Trangthai)
        {
            Word = Tu;
            WordMeaning = Nghia;
            WordType = LoaiTu;
            WordExample = ViDu;
            Status = Trangthai;
        }
    }
}
