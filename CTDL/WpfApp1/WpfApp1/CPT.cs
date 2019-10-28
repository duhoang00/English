using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CPT
    {
        //Thuộc tính
        private string english;
        private string vietnamese;
        private string example;
        private string status;

        public string ENG
        {
            get => english;
            set => english = value;
        }
        public string Viet
        {
            get => vietnamese;
            set => vietnamese = value;
        }
        public string Ex
        {
            get => example;
            set => example = value;
        }
        public string Status
        {
            get => status;
            set => status = value;
        }

        //Khởi tạo
        public CPT(string a, string b, string c)
        {
            ENG = a;
            Viet = b;
            Ex = c;
            
        }
    }
}
