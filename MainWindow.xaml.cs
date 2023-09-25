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
        List<Triangle> triangles = new List<Triangle>();
        double num, num2, num3;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if ((double.TryParse(box.Text, out num)==false)|| (double.TryParse(box2.Text, out num2) == false) || (double.TryParse(box3.Text, out num3) == false))
            {
                MessageBox.Show("請使用者重新輸入");
                return;
            }
            if((num<1)|| (num2 < 1)|| (num3 < 1)) {
                MessageBox.Show("數值小於1","請使用者重新輸入");
                return;
            }
            if((num+num2>num3) && (num2+num3 > num) && (num3+ num > num2)) 
            {
                lab.Background = Brushes.DarkTurquoise;
                lab.Content = $"邊長{num},{num2},{num3}可構成三角形";
                triangles.Add(new Triangle() { Side1 = num, Side2 = num2, Side3 = num3, Istriangle = true });
            }
            else
            {
                lab.Background = Brushes.Red;
                lab.Content = $"邊長{num},{num2},{num3}不可構成三角形";
                triangles.Add(new Triangle() { Side1 = num, Side2 = num2, Side3 = num3, Istriangle = false });
            }
            butter();
        }
        private void butter()
        {
            block.Text="";
            foreach (Triangle t in triangles)
            {
                if (t.Istriangle)
                {
                    block.Text += $"邊長{t.Side1} {t.Side2} {t.Side3} 是三角形\n";
                }
                else
                {
                    block.Text += $"邊長{t.Side1} {t.Side2} {t.Side3} 不是三角形\n";
                }
            }
        }
    }
}
