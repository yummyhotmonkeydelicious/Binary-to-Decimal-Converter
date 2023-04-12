using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {

        public static bool IsLeapYear(int year)
        {
            bool ans = false;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                ans = true;
            return ans;
        }

        public static void MultTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }

        public static double FractionSum(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (1 / (double)(i * i));
            }
            return sum;
        }

        static int[] SortArrayAscend(int[] x)
        {
            int temp;
            List<int> ans = new List<int>();
            for (int i = 0; i < x.Length - 1; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        temp = x[j + 1];
                        x[j + 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
            return x;
        }

        static int BiggestNum(int[] nums)
        {
            int biggestNum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= biggestNum)
                    biggestNum = nums[i];
            }
            return biggestNum;
        }

        static int NumOfSeven(int[] nums)
        {
            int numSevens = 0;
            for(int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i + 1]  == 7 && nums[i] == 7)
                {
                    numSevens++;
                }
            }
            return numSevens;
        }

        static bool ThreeIncreasing(int[] nums)
        {
            bool ans = false;
            for(int i  = 1; i < nums.Length - 1; i++)
            {
                if (nums[i - 1] == nums[i] - 1 && nums[i] + 1 == nums[i + 1])
                {
                    ans = true;
                }
            }
            return ans;
        }

        public static int ModuloOperations(int one, int two, int three)
        {
            int y = one % two;
            int answer = y % three;
            return answer;
        }

        public static bool[] SieveofEratosthenes(int n)
        {
            bool[] array = new bool[n];
            for(int i = 2; i < n; i++)
            {
                array[i] = true;
            }
            for(int j = 2; j*j <= n; j++)
            {
                if (array[j] == true)
                {
                    for(int k = j*j; k < n; k += j)
                    {
                        array[k] = false;
                    }
                }
            }
            return array;
        }

        public static bool CheckBracketsSequence(string input)
        {
            int numClosingBrackets = 0;
            int numBrackets = 0;
            bool answer = false;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    numBrackets++;
                }
                if (input[i] == ')')
                {
                    numClosingBrackets++;
                }
            }
            if (numBrackets == numClosingBrackets)
            {
                answer = false;
            }
            return answer;
        }

        public static string AddSeperator(string input)
        {
            string answer = Regex.Replace(input, ".{1}", "$0*");
            return answer;
        }

        public static int LengthofString(string input)
        {
            int i = 0;
            foreach(var c in input)
            {
                i++;
            }
            return i;
        }

        public static string ReverseOrder(string input)
        {
            string answer = "";
            for(int i = input.Length; i > input.Length; i--)
            {
                Console.WriteLine(i);
            }
            return answer;
        }

        static void Main(string[] args)
        {
            
        }
    }
}