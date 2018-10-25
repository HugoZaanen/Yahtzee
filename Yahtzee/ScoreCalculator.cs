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

        public static int CountNumbers(int[] arr)
        {
            int sum = 0;

            for (int i = 0;i < arr.Length;i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static bool Toak(int[] arr)
        {
            int count = 0;

            for (int j = 0; j < 3; j++)
            {

                int a = arr[j];
                count++;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (a == arr[i] && i != j)
                    {
                        count++;
                    }
                }
                if (count == 2 || count == 1)
                {
                    count = 0;
                }
                else if (count >= 3)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Foak(int[] arr)
        {
            int count = 0;

            for (int j = 0; j < 3; j++)
            {
                int a = arr[j];
                count++;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (a == arr[i] && i != j)
                    {
                        count++;
                    }
                }
                if (count == 2 || count == 1)
                {
                    count = 0;
                }
                else if (count == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool FullHouse(int[] arr)
        {
            Array.Sort(arr);

            if (arr[0] == arr[1] && arr[0] == arr[2] && arr[0] != arr[3] && arr[0] != arr[4])
            {
                return true;
            }
            else if (arr[2] == arr[3] && arr[2] == arr[4] && arr[2] != arr[0] && arr[2] != arr[1])
            {
                return true;
            }

            return false;
        }

        public static bool SmallStraight(int[] arr)
        {
            Array.Sort(arr);

            if (arr[4] - 1 == arr[3] && arr[3] - 1 == arr[2])
            {
                return true;
            }
            else if(arr[3] - 1 == arr[2] && arr[2] - 1 == arr[1])
            {
                return true;
            }
            else if(arr[2] - 1 == arr[1] && arr[1] - 1 == arr[0])
            {
                return true;
            }

            return false;
        }

        public static bool Yahtzee(int[] arr)
        {
            int a = arr[0];
            int count = 1;

            for (int i = 1;i < arr.Length;i++)
            {
                
                if (a == arr[i])
                {
                    count++;
                }
            }

            if (count == 5)
            {
                return true;
            }
            return false;
        }

        public static bool BigStraight(int[] arr)
        {
            Array.Sort(arr);

            if (arr[4] - 1  == arr[3] && arr[3] - 1 == arr[2] && arr[2] - 1 == arr[1] && arr[1] - 1 == arr[0]) 
            {
                return true;
            }

            return false;
        }
    }
}