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
        public MainWindow()
        {
            InitializeComponent();            
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
                EnglishWord EnglishWordWindow = new EnglishWord(txt_Seach.Text, "Show");
            }
        }

        private void btn_Fix_Click(object sender, RoutedEventArgs e)
        {
            EnglishWord EnglishWordWindow = new EnglishWord();
            EnglishWordWindow.Show();
        }
    }
}
