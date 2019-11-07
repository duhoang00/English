using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace English
{
    class ArrayChuCai : MainWindow
    {
        public ListPhanTu[] DSPT = new ListPhanTu[26];

        public ArrayChuCai()
        {
            InitializeComponent();
            TaoDS();
        }

        public void TaoDS()
        {
            for (int i = 0; i < 26; i++)
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
            if (WordMeaning != "")
            {
                for (int i = 0; i < WordMeaning.Length; i++)
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
            }
            else
            {
                writetext.Write("");
            }

            //Viet loai tu
            if (WordType != null)
            {
                writetext.Write(WordType + "/");
            }
            else
            {
                writetext.Write("");
            }

            //Viet vi du tu
            if (WordExample != null)
            {
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
            }
            writetext.WriteLine("|");

            writetext.Close();
        }

        public void DocTu()
        {
            //Chay 26 chu cai cho 26 file
            for (Char c = 'A'; c <= 'Z'; c++)
            {
                //Check file co ton tai khong
                if (File.Exists(c + ".txt")) {
                    String s;
                    
                    //Mo file
                    StreamReader readtext = new StreamReader(c + ".txt");

                    //Doc tung dong
                    while ((s = readtext.ReadLine()) != null)
                    {
                        PhanTu TheWord = new PhanTu();
                        String ss = "";
                        int dem = 0;

                        //Chay tu dau chuoi den cuoi chuoi
                        for (int i = 0; i < s.Length; i++)
                        {
                            String a = s[i].ToString();
                            if (s[i].ToString() != "/")
                            {
                                ss += s[i];
                            }
                            if (s[i].ToString() == "/" && dem == 0)
                            {
                                TheWord.Word = ss;
                                ss = "";
                                dem = 1;
                            }
                            else if (s[i].ToString() == "/" && dem == 1)
                            {
                                TheWord.WordType = ss;
                                ss = "";
                                dem = 2;
                            }
                            else if (s[i].ToString() == "/" && dem == 2)
                            {
                                TheWord.WordMeaning = ss;
                                ss = "";
                                dem = 3;
                            }
                            else if (i == (s.Length -1) && dem == 3)
                            {
                                TheWord.WordExample = ss;
                                ss = "";
                                dem = 4;
                            }
                        }
                        //Duoc 1 TheWord

                        //Tao Node cho TheWord
                        PhanTuNode NodeTheWord = new PhanTuNode(TheWord);

                        //Gan vao list
                        int n = Convert.ToInt32(c) - 65;
                        PhanTuNode Mickey = DSPT[n].head;
                        
                        if (DSPT[n].head == null && DSPT[n].tail == null)
                        {
                            DSPT[n].head = DSPT[n].tail = NodeTheWord; 
                        }
                        else
                        {
                            DSPT[n].tail.next = NodeTheWord;
                            DSPT[n].tail = NodeTheWord;
                        }
                    }
                }
            }
        }

        public void WordSearch(String key)
        {
            DocTu();
            int ChuDauTien = Convert.ToInt32(key[0]) - 65;
            ListPhanTu CaiList = DSPT[ChuDauTien];

            PhanTuNode Donald = CaiList.head;

            MainWindow Form = Application.Current.Windows[0] as MainWindow;
            Form.lv_Words.Items.Clear();

            while (Donald != null)
            {
                if (Donald != null && Donald.data.Word.Contains(key))
                {
                    Form.lv_Words.Items.Add(Donald.data.Word);                   
                }
                Donald = Donald.next;
            }
        }       
    }
}
