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
        int numRolls = 0;

        bool halt1 = false;
        bool halt2 = false;
        bool halt3 = false;
        bool halt4 = false;
        bool halt5 = false;

        int num = 1;
        int num1 = 1;
        int num2 = 1;
        int num3 = 1;
        int num4 = 1;

        bool mouseActivate = false;

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

                if (!halt1)
                {
                    num = rand.Next(1, 6);
                }

                if (!halt2)
                {
                    num1 = rand.Next(1, 6);
                }
                if (!halt3)
                {
                    num2 = rand.Next(1, 6);
                }
                if (!halt4)
                {
                    num3 = rand.Next(1, 6);
                }
                if (!halt5)
                {
                    num4 = rand.Next(1, 6);
                }

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

                mouseActivate = true;
            }
        }
    

        private void player1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (numRolls != 0)
            {
                TextBlock block = sender as TextBlock;

                int num1 = Int32.Parse(box1.Text);
                int num2 = Int32.Parse(box2.Text);
                int num3 = Int32.Parse(box3.Text);
                int num4 = Int32.Parse(box4.Text);
                int num5 = Int32.Parse(box5.Text);

                if (block.Name == "player1" && mouseActivate)
                {
                    block.Text = "" + ScoreCalculator.CountOnes(nums);
                }
                else if (block.Name == "player2")
                {
                    block.Text = "" + ScoreCalculator.CountTwos(nums);
                }
                else if (block.Name == "player3" && mouseActivate)
                {
                    block.Text = "" + ScoreCalculator.CountThrees(nums);
                }
                else if (block.Name == "player4" && mouseActivate)
                {
                    block.Text = "" + ScoreCalculator.CountFours(nums);
                }
                else if (block.Name == "player5" && mouseActivate)
                {
                    block.Text = "" + ScoreCalculator.CountFives(nums);
                }
                else if (block.Name == "player6" && mouseActivate)
                {
                    block.Text = "" + ScoreCalculator.CountSix(nums);
                }
                else if (block.Name == "ThreeOfAKind" && mouseActivate)
                {
                    if (ScoreCalculator.Toak(nums))
                    {
                        block.Text = "" + ScoreCalculator.CountNumbers(nums);
                    }
                    else
                    {
                        block.Text = "0";
                    }
                }
                else if (block.Name == "FourOfaKind" && mouseActivate)
                {
                    if (ScoreCalculator.Foak(nums))
                    {
                        block.Text = "" + ScoreCalculator.CountNumbers(nums);
                    }
                    else
                    {
                        block.Text = "0";
                    }
                }
                else if (block.Name == "FullHouse" && mouseActivate)
                {
                    if (ScoreCalculator.FullHouse(nums))
                    {
                        block.Text = "25";
                    }
                    else
                    {
                        block.Text = "0";
                    }
                }
                else if (block.Name == "SmallStraight" && mouseActivate)
                {
                    if (ScoreCalculator.SmallStraight(nums))
                    {
                        block.Text = "25";
                    }
                    else
                    {
                        block.Text = "0";
                    }
                }
                else if (block.Name == "LargeStraight" && mouseActivate)
                {
                    if (ScoreCalculator.BigStraight(nums))
                    {
                        block.Text = "" + 40;
                    }
                    else
                    {
                        block.Text = "0";
                    }
                }
                else if (block.Name == "Chance" && mouseActivate)
                {
                    block.Text = "" + ScoreCalculator.CountNumbers(nums);
                }
                else if (block.Name == "YAHTZEE" && mouseActivate)
                {
                    if (ScoreCalculator.Yahtzee(nums))
                    {
                        block.Text = "" + 50;
                    }
                    else
                    {
                        block.Text = "" + 0;
                    }
                }

                mouseActivate = false;
                numRolls = 0;
                txtBox.Text = "" + numRolls;
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (numRolls != 0)
            {
                if (!halt1)
                {
                    halt1 = true;
                }
                else
                {
                    halt1 = false;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (numRolls != 0)
            {
                if (!halt2)
                {
                    halt2 = true;
                }
                else
                {
                    halt2 = false;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (numRolls != 0)
            {
                if (!halt3)
                {
                    halt3 = true;
                }
                else
                {
                    halt3 = false;
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (numRolls != 0)
            {
                if (!halt4)
                {
                    halt4 = true;
                }
                else
                {
                    halt4 = false;
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (numRolls != 0)
            {
                if (!halt5)
                {
                    halt5 = true;
                }
                else
                {
                    halt5 = false;
                }
            }
        }
    }
}