using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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



namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool count = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> Triangle = new List<string>();
            count = true;
            double num,num2,num3;
            if ((double.TryParse(box.Text, out num)==false)|| (double.TryParse(box2.Text, out num2) == false) || (double.TryParse(box3.Text, out num3) == false))
            {
                MessageBox.Show("請使用者重新輸入");
            }
            else if((num<0)|| (num2 < 0)|| (num3 < 0)) {
                MessageBox.Show("數值小於0","請使用者重新輸入");
            }
            else if((num+num2<num3) || (num2+num3 < num) || (num3+ num < num2)) 
                {
                lab.Background = Brushes.Red;
                string n1 = $"邊長{num},{num2},{num3}不可構成三角形";
                lab.Content = n1;
                
                string count= $"邊長{num},{num2},{num3}不可構成三角形";
            }
            else
            {
                lab.Background = Brushes.Green;
                string n1 = $"邊長{num},{num2},{num3}可構成三角形";
                lab.Content = n1;

                string count = $"邊長{num},{num2},{num3}可構成三角形";
            }

        }

        private static void ListResult(List<string> myPrimes, string n)
        {

        }

    }
}
