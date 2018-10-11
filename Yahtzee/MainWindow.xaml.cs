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

namespace Yahtzee
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

        private void RollBttn_Click(object sender, RoutedEventArgs e)
        {
            Random rand  = new Random();
            Random rand1 = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            Random rand4 = new Random();

            int num = rand.Next(1,6);
            int num1 = rand.Next(1,6);
            int num2 = rand.Next(1,6);
            int num3 = rand.Next(1,6);
            int num4 = rand.Next(1,6);

            box1.Text = "" + num;
            box2.Text = "" + num1;
            box3.Text = "" + num2;
            box4.Text = "" + num3;
            box5.Text = "" + num4;

            
        }

        private void player1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock block = sender as TextBlock;

            int num1 = Int32.Parse(box1.Text);
            int num2 = Int32.Parse(box2.Text);
            int num3 = Int32.Parse(box2.Text);
            int num4 = Int32.Parse(box2.Text);
            int num5 = Int32.Parse(box2.Text);

            block.Text = "" + (num1 + num2 + num3 + num4 + num5);
        }
    }
}
