using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace English
{
    /// <summary>
    /// Interaction logic for EnglishWord.xaml
    /// </summary>
    public partial class EnglishWord
    {
        ArrayChuCai DS = new ArrayChuCai();

        public EnglishWord()
        {
            InitializeComponent();
        }

        public EnglishWord(String key,String lenh)
        {
            DS.DocTu();
            ListPhanTu x = new ListPhanTu();
            x = DS.WordSearch(key);
            MainWindow Form = Application.Current.Windows[0] as MainWindow;

            if (key == "Showfulllist")
            {
                DS.ShowListWord();
            }

            if (lenh == "Show")
            {
                PhanTuNode Mickey = x.head;
                while(Mickey.data.Word != key && Mickey != null)
                {
                    Mickey = Mickey.next;
                }                
                Form.lbl_TheWord.Content = Mickey.data.Word;

                Form.lbl_WordType.Content = Mickey.data.WordType;

                Mickey.data.WordMeaning = Mickey.data.WordMeaning.Replace("+", Environment.NewLine + "-");
                Form.lbl_WordMeaning.Content = "-" + Mickey.data.WordMeaning;

                Mickey.data.WordExample = Mickey.data.WordExample.Replace("+", Environment.NewLine + "-");
                Form.lbl_WordExample.Content = "-" + Mickey.data.WordExample;
            }

            if (lenh == "Delete")
            {
                string filePath = key[0].ToString() + ".txt";
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

                StreamReader readtext = new StreamReader(fs);

                String s;
                String All = "";
                String ss = "";
                Boolean flag = true;
                while ((s = readtext.ReadLine()) != null)
                {
                    ss = "";
                    flag = true;
                    for (int i = 0; i < s.Length;i++)
                    {
                        ss += s[i];
                        if (ss == key)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        All += s;
                    }
                }
                fs.Close();
                File.WriteAllText(key[0].ToString() + ".txt", All);                                                
            }
        }

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Word.Text != "")
            {
                String Word = txt_Word.Text.ToUpper();                
                String WordType = "";
                WordType = this.cmb_WordType.SelectionBoxItem.ToString();
                txt_WordMeaning.Text = txt_WordMeaning.Text.Replace(Environment.NewLine, "+");
                txt_WordExample.Text = txt_WordExample.Text.Replace(Environment.NewLine, "+");
                DS.ThemTu(Word, txt_WordMeaning.Text, WordType, txt_WordExample.Text);
                this.Close();
                MessageBox.Show("Success", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please enter some word", "WARNING!!!", MessageBoxButton.OK, MessageBoxImage.Warning); 
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Everything has been written will be deleted \n This can not be undone \n Are you sure","WARNING!!!",MessageBoxButton.YesNo,MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                txt_Word.Text = "";
                txt_WordMeaning.Text = "";
                txt_WordExample.Text = "";
                cmb_WordType.SelectedItem = null;
            }
        }

        private void btn_Mark_Click(object sender, RoutedEventArgs e)
        {
            if(btn_Mark.Content.ToString() == "Mark")
            {
                btn_Mark.Content = "Unmark";
            }
            else if (btn_Mark.Content.ToString() == "Unmark")
            {
                btn_Mark.Content = "Mark";
            }
        }
    }
}
