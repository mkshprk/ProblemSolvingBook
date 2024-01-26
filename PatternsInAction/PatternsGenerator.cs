using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsInAction
{
    public static class PatternsGenerator
    {
        /// <summary>
        /// ****
        /// ****
        /// ****
        /// </summary>
        /// <param name="n">Number of rows to print</param>
        public static void Pattern1(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// *
        /// **
        /// ***
        /// </summary>
        /// <param name="n">Number of rows to print</param>
        public static void Pattern2(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// ****
        /// ***
        /// **
        /// *
        /// </summary>
        /// <param name="n">Number of rows to print</param>
        public static void Pattern3(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= (n + 1) - row; col++) // For 1st row it's n and for last row it's 1 
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// 1
        /// 12
        /// 123
        /// </summary>
        /// <param name="n">Number of rows to print</param>
        public static void Pattern4(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// *
        /// **
        /// ***
        /// ****
        /// ***
        /// **
        /// *
        /// </summary>
        /// <param name="n">Number of rows to print</param>
        public static void Pattern5(int n) 
        {
            for (int row = 1; row <= (2 * n) - 1; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine("");
            }
        }
    }
}
