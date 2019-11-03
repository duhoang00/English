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

namespace English
{
    /// <summary>
    /// Interaction logic for EnglishWord.xaml
    /// </summary>
    public partial class EnglishWord : Window
    {
        ArrayChuCai DS = new ArrayChuCai();

        public EnglishWord()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            String Word = txt_Word.Text.ToUpper();
            string WordType = this.cmb_WordType.SelectionBoxItem.ToString();
            DS.ThemTu(Word, txt_WordMeaning.Text, WordType ,txt_WordExample.Text);
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            txt_Word.Text= "";
            txt_WordMeaning.Text = "";
            txt_WordExample.Text = "";
            cmb_WordType.SelectedItem = null;
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
