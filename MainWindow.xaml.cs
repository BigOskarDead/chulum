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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] gg = new Button[10];
        int a = 0;
        public MainWindow()
        {


            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Введите блюдо из основного меню или воспользуйтесь комплиментом от шеф повора добавте свое блюдо.");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            gg[a] = new Button();
            gg[a].Content = textName.Text;
            gg[a].Tag = a;
            gg[a].Click += new RoutedEventHandler(this.Button_Click_4);
            comboBox1.Items.Add(gg[a]);
            a++;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = 0;
                i++;
                comboBox1.Items.RemoveAt(i);
            }
            catch
            {
                MessageBox.Show("Вы все удалили");
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int f;
            f = rand.Next(1, 100);
            MessageBox.Show("С вас " + f.ToString() + " рублей");
        }
        private void Button_Click_4(object sender, EventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();

        }






        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (re.Text.Equals(Convert.ToString(gg[i].Content)))
                {
                    comboBox1.IsDropDownOpen = true;
                    gg[i].Foreground = Brushes.Orange;
                }
                else
                {
                    gg[i].Foreground = Brushes.Black;
                }
            }
        }
    }
}
