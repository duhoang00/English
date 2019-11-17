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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace English
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String selectedkey;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            EnglishWord EnglishWordWindow = new EnglishWord("Showfulllist", "Du dep trai");
        }

        private void Btn_Nhap_Click(object sender, RoutedEventArgs e)
        {
            EnglishWord EnglishWordWindow = new EnglishWord();
            EnglishWordWindow.Show();
        }

        public void txt_Seach_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_Seach.Text != "")
            {
                String key = txt_Seach.Text.ToUpper();
                EnglishWord EnglishWordWindow = new EnglishWord(key, "Search");
            }
            else
            {
                lv_Words.Items.Clear();
            }
        }

        private void lv_Words_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lv_Words.SelectedItem != null)
            {
                selectedkey = lv_Words.SelectedItem.ToString().ToUpper();
                EnglishWord EnglishWordWindow = new EnglishWord(selectedkey, "Show");
            }
        }

        private void btn_Fix_Click(object sender, RoutedEventArgs e)
        {
            if (selectedkey != null)
            {
                ArrayChuCai DS = new ArrayChuCai();
                DS.DocTu();
                ListPhanTu x = new ListPhanTu();
                x = DS.WordSearch(selectedkey);
                PhanTuNode Duy = x.head;
                while (Duy.data.Word != selectedkey && Duy != null)
                {
                    Duy = Duy.next;
                }
                EnglishWord EnglishWordWindow = new EnglishWord();
                EnglishWordWindow.Show();
                EnglishWordWindow.txt_Word.Text = Duy.data.Word;
                EnglishWordWindow.txt_WordExample.Text = Duy.data.WordExample;
                EnglishWordWindow.txt_WordMeaning.Text = Duy.data.WordMeaning;
                EnglishWordWindow.cmb_WordType.Text = Duy.data.WordType;
                if (Duy.data.Status =="Mark")
                {
                    EnglishWordWindow.rbn_Mark.IsChecked = true;
                }
                EnglishWordWindow = new EnglishWord(selectedkey, "Delete");
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (selectedkey != null)
            {               
                EnglishWord EnglishWordWindow = new EnglishWord(selectedkey, "Delete");
            }
        }

        private void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            EnglishWord EnglishWordWindow = new EnglishWord("Showfulllist", "Du dep trai");
        }

        private void Btn_Game_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.Show();
        }
    }
}
