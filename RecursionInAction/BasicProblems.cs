using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionInAction
{
    class BasicProblems
    {
        /// <summary>
        /// T.C. : O(n)
        /// S.C. : O(n)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="n"></param>
        public static void Print_String_N_Times(string text, int n)
        {
            if (n < 1)
                return;

            Console.WriteLine(text);
            Print_String_N_Times(text,n-1);
        }

        #region Printing numbers linearly in ascending order
        public static void Print_Linearly_From_1_To_N(int n)
        {
            if (n < 1)
                return;

            Print_Linearly_From_1_To_N(n-1);
            Console.WriteLine(n);
        }

        public static void Print_Linearly_From_1_To_N_Striver(int n, int i = 1)
        {
            if (i > n)
                return;
            Console.WriteLine(i);
            Print_Linearly_From_1_To_N_Striver(n, i + 1);
        }
        #endregion

        #region Print numbers linearly in descending order
        public static void Print_Linearly_From_N_To_1(int n)
        {
            if (n < 1)
                return;

            Console.WriteLine(n);
            Print_Linearly_From_N_To_1(n-1);
        }
        #endregion

        #region Summation of first N numbers

        /// <summary>
        /// Here we parameters to build up results
        /// </summary>
        /// <param name="n"></param>
        /// <param name="sum"></param>
        public static void SummationOfNumbers_ParameterizedWay(int n, int sum = 0)
        {
            if (n < 1)
            {
                Console.WriteLine(sum);
                return;
            }

            SummationOfNumbers_ParameterizedWay(n - 1, sum + n);
        }

        /// <summary>
        /// Here we return results
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SummationOfNumbers_Functional(int n)
        {
            if (n < 1)
                return 0;

            return n + SummationOfNumbers_Functional(n - 1);
        }

        #endregion

        #region Factorial
        public static double Factorial(int n)
        {
            if (n <= 0) return 1;
            return n * Factorial(n-1);
        }
        #endregion

        #region
        #endregion

    }
}
