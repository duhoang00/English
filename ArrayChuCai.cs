using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace English
{
    class ArrayChuCai
    {
        public ListPhanTu[] DSPT = new ListPhanTu[26];

        public ArrayChuCai()
        {
            for (int i = 0; i< 26; i++)
            {
                DSPT[i] = new ListPhanTu();
            }
            int j = 0;
            for (Char c = 'A'; c <= 'Z'; c++)
            {
                DSPT[j].FL = c.ToString();
                j++;
            }
        }

        public void ThemTu(String Word, String WordMeaning, String WordType, String WordExample)
        {
            //Mo file
            String key = Word[0].ToString();
            StreamWriter writetext = File.AppendText(key + ".txt");
            //Viet tu tieng anh
            writetext.Write(Word+"/");
            //Viet nghia
            for (int i = 0; i<WordMeaning.Length;i++)
            {            
                if (WordMeaning[i].ToString() == "\\n")
                {
                    writetext.Write("+");
                }
                else
                {
                    writetext.Write(WordMeaning[i]);
                }
            }
            writetext.Write("/");
            //Viet loai tu
            writetext.Write(WordType + "/");
            //Viet vi du tu
            for (int i = 0; i < WordExample.Length; i++)
            {
                if (WordExample[i].ToString() == "\\n")
                {
                    writetext.Write("+");
                }
                else
                {
                    writetext.Write(WordExample[i]);
                }
            }
            writetext.WriteLine("|");
            writetext.Close();
        }

        public void DocTu(String Word)
        {
            String key = Word[0].ToString();
            StreamReader writetext = new StreamReader(key + ".txt");
            writetext.ReadLine();
        }
    }
}
