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
        Gamedata data = new Gamedata();
        int Sothutu = 0;
        int Score = 0;
        public Game()
        {
            InitializeComponent();
            MessageBox.Show("Điền từ đúng, mỗi từ được 10đ.", "Hướng dẫn", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            Start(Sothutu);
        }
        private void Start(int i)
        {
            txt_Ques.Content = data.XuatQ(i);
            int[] Pos = new int[] { 1, 2, 3, 4 };
            Random Rd = new Random();
            int a = Rd.Next(1, 3);
            int c = Pos[a];
            Pos[a] = Pos[0];
            Pos[0] = c;
            btn_Ans1.Content = data.XuatA(i, Pos[0]);
            btn_Ans2.Content = data.XuatA(i, Pos[1]);
            btn_Ans3.Content = data.XuatA(i, Pos[2]);
            btn_Ans4.Content = data.XuatA(i, Pos[3]);
        }
        private void Xuli()
        {
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
        }
        private void Btn_Ans1_Click(object sender, RoutedEventArgs e)
        {
            if (btn_Ans1.Content == data.XuatA(Sothutu,1))
            {
                Score++;
            }
            Sothutu++;
            Xuli();
            Start(Sothutu);
        }

        private void Btn_Ans2_Click(object sender, RoutedEventArgs e)
        {
            if( btn_Ans2.Content==data.XuatA(Sothutu,1))
            {
                Score++;
            }
            Sothutu++;
            Xuli();
            Start(Sothutu);
        }

        private void Btn_Ans3_Click(object sender, RoutedEventArgs e)
        {
            if (btn_Ans3.Content == data.XuatA(Sothutu, 1))
            {
                Score++;
            }
            Sothutu++;
            Xuli();
            Start(Sothutu);
        }

        private void Btn_Ans4_Click(object sender, RoutedEventArgs e)
        {
            if (btn_Ans4.Content == data.XuatA(Sothutu, 1))
            {
                Score++;
            }
            Sothutu++;
            Xuli();
            Start(Sothutu);
        }
    }
}
