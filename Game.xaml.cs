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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
            MessageBox.Show("Điền từ đúng, mỗi từ được 10đ.", "Hướng dẫn", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            Start(Sothutu);
        }
        Gamedata data = new Gamedata();
        int Sothutu = 0;
        int Score = 0;
        private void Start(int i)
        {
            txt_Ques.Content = data.XuatQ(i);
            btn_Ans1.Content = data.XuatA(i, 1);
            btn_Ans2.Content = data.XuatA(i, 2);
            btn_Ans3.Content = data.XuatA(i, 3);
            btn_Ans4.Content = data.XuatA(i, 4);
        }

        private void Btn_Ans1_Click(object sender, RoutedEventArgs e)
        {
            Sothutu++;
            Score++;
            if(Sothutu == 10)
            {
                MessageBoxResult result = MessageBox.Show("Số điểm của bạn: " + Score * 10 + "\n Bạn có muốn chơi lại hông?", "Results", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result==MessageBoxResult.Yes)
                {
                    Sothutu = 0;
                    Score = 0;
                    Start(Sothutu);
                }
                else if(result == MessageBoxResult.No)
                {
                    Sothutu = 0;
                    Score = 0;
                    frmGame.Close();
                }
            }
            Start(Sothutu);
        }

        private void Btn_Ans2_Click(object sender, RoutedEventArgs e)
        {
            Sothutu++;
            if (Sothutu == 10)
            {
                MessageBoxResult result = MessageBox.Show("Số điểm của bạn: " + Score * 10 + "\n Bạn có muốn chơi lại hông?", "Results", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Sothutu = 0;
                    Score = 0;
                    Start(Sothutu);
                }
                else if (result == MessageBoxResult.No)
                {
                    Sothutu = 0;
                    Score = 0;
                    frmGame.Close();
                }
            }
            Start(Sothutu);
        }

        private void Btn_Ans3_Click(object sender, RoutedEventArgs e)
        {
            Sothutu++;
            if (Sothutu == 10)
            {
                MessageBoxResult result = MessageBox.Show("Số điểm của bạn: " + Score * 10 + "\n Bạn có muốn chơi lại hông?", "Results", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Sothutu = 0;
                    Score = 0;
                    Start(Sothutu);
                }
                else if (result == MessageBoxResult.No)
                {
                    Sothutu = 0;
                    Score = 0;
                    frmGame.Close();
                }
            }
            Start(Sothutu);
        }

        private void Btn_Ans4_Click(object sender, RoutedEventArgs e)
        {
            Sothutu++;
            if (Sothutu == 10)
            {
                MessageBoxResult result = MessageBox.Show("Số điểm của bạn: " + Score * 10 + "\n Bạn có muốn chơi lại hông?", "Results", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Sothutu = 0;
                    Score = 0;
                    Start(Sothutu);
                }
                else if (result == MessageBoxResult.No)
                {
                    Sothutu = 0;
                    Score = 0;
                    frmGame.Close();
                }
            }
            Start(Sothutu);
        }
    }
}
