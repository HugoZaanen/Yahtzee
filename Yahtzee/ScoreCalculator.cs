using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class ScoreCalculator
    {

        public static int CountOnes(int[] array)
        {
            return CountOneToSix(array, 1);
        }

        public static int CountTwos(int[] array)
        {
            return CountOneToSix(array, 2);
        }

        public static int CountThrees(int[] array)
        {
            return CountOneToSix(array, 3);
        }

        public static int CountFours(int[] array)
        {
            return CountOneToSix(array, 4);
        }

        public static int CountFives(int[] array)
        {
            return CountOneToSix(array, 5);
        }

        public static int CountSix(int[] array)
        {
            return CountOneToSix(array, 6);
        }

        

        public static int CountOneToSix(int[] array, int number)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i == number)
                {
                    sum += number;
                }
            }
            return sum;
        }       
    }
}
