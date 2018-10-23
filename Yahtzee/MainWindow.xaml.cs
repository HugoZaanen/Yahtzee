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
        
        int[] nums = new int[5];
        int numRolls = 1;
        
        public MainWindow()
        {
            InitializeComponent();
            txtBox.Text = "" + numRolls;
        }
               
        private void RollBttn_Click(object sender, RoutedEventArgs e)
        {
            if (numRolls < 3)
            {
                numRolls++;
                txtBox.Text = "" + numRolls;

                Random rand = new Random();
                Random rand1 = new Random();
                Random rand2 = new Random();
                Random rand3 = new Random();
                Random rand4 = new Random();

                int num = rand.Next(1, 6);
                int num1 = rand.Next(1, 6);
                int num2 = rand.Next(1, 6);
                int num3 = rand.Next(1, 6);
                int num4 = rand.Next(1, 6);

                nums[0] = num;
                nums[1] = num1;
                nums[2] = num2;
                nums[3] = num3;
                nums[4] = num4;

                box1.Text = "" + num;
                box2.Text = "" + num1;
                box3.Text = "" + num2;
                box4.Text = "" + num3;
                box5.Text = "" + num4;
            }
        }
    

        private void player1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock block = sender as TextBlock;

            int num1 = Int32.Parse(box1.Text);
            int num2 = Int32.Parse(box2.Text);
            int num3 = Int32.Parse(box2.Text);
            int num4 = Int32.Parse(box2.Text);
            int num5 = Int32.Parse(box2.Text);
            
            if(block.Name == "player1" )
            {
                block.Text = "" + ScoreCalculator.CountOnes(nums);
            }
            else if(block.Name == "player2")
            {
                block.Text = "" + ScoreCalculator.CountTwos(nums);
            }
            else if(block.Name == "player3")
            {
                block.Text = "" + ScoreCalculator.CountThrees(nums);
            }
            else if(block.Name == "player4")
            {
                block.Text = "" + ScoreCalculator.CountFours(nums);
            }
            else if(block.Name == "player5")
            {
                block.Text = "" + ScoreCalculator.CountFives(nums);
            }
            else if(block.Name == "player6")
            {
                block.Text = "" + ScoreCalculator.CountOnes(nums);
            }
            else if(block.Name == "TwoOfaKind")
            {

            }
            else if (block.Name == "FourOfaKind")
            {

            }
            else if (block.Name == "FullHouse")
            {

            }
            else if (block.Name == "SmallStraight")
            {

            }
            else if (block.Name == "BigStraight")
            {

            }
            else if (block.Name == "Chance")
            {

            }
            else if (block.Name == "YAHTZEE")
            {

            }

            //block.Text = "" + (num1 + num2 + num3 + num4 + num5);

            block.IsEnabled = false;
             numRolls = 1;
             txtBox.Text = "" + numRolls;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Array.Sort<int>(nums);
        }        
    }
}
