using System;

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

        #region Reverse an Array
        public static void ReverseArrayUsingLoop()
        {
            var arr = new int[] { 1,2,3,4,2}; //2 4 3 2 1
            int start = 0;
            int last = arr.Length - 1;

            while(start < last)
            {
                Helpers.SwapArrayElements(arr, start, last);
                start++;
                last--;
            }
        }
        public static int[] ReverseArrayUsing_2Pointers(int [] arr, int start, int last)
        {
            if (start >= last) return arr;
            Helpers.SwapArrayElements(arr, start, last);
            return ReverseArrayUsing_2Pointers(arr,++start,--last);
        }
        public static int[] ReverseArrayUsing_2Pointers(int[] arr, int start)
        {
            int index = arr.Length - start - 1;
            if (index == start) return arr;
            Helpers.SwapArrayElements(arr, start, index);
            return ReverseArrayUsing_2Pointers(arr, ++start);
        }
        #endregion

        #region Check if a string is Palindrome or not
        /// <summary>
        /// T.C. : O(n/2) => O(n)
        /// S.C. : O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsStringPalindrome(string input)
        {
            var start = 0;
            var length = input.Length - 1;

            while(start <= length)
            {
                if (input[start] != input[length - start]) return false;
                ++start;
            }

            return true;
        }

        /// <summary>
        /// T.C. : O(n/2) => O(n)
        /// S.C. : O(n/2) => O(n)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static bool IsStringPalindrome_Recursion(string input, int start = 0)
        {
            if (start >= (input.Length)/2) return true;
            if (input[start] != input[input.Length - 1 - start]) return false;
            return IsStringPalindrome_Recursion(input, ++start);
        }
        #endregion

        #region Fibonacci 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,....
        // Different approaches : https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/

        /// <summary>
        /// T.C. : Exponential, as every function calls 2 other functions ~2^n
        /// S.C. : O(n) : function call stack size
        /// </summary>
        /// <param name="nthFibonacciToGet"></param>
        /// <returns></returns>
        public static int Fibonacci_Worst(int nthFibonacciToGet)
        {
            if (nthFibonacciToGet <= 1)
                return nthFibonacciToGet;

            return Fibonacci_Worst(nthFibonacciToGet - 1) + Fibonacci_Worst(nthFibonacciToGet - 2);
        }

        /// <summary>
        /// T.C. : O(n)
        /// S.C. : O(n)
        /// </summary>
        /// <param name="nthFibonacciToGet"></param>
        /// <returns></returns>
        public static int Fibonacci_DP(int nthFibonacciToGet)
        {
            int[] fibs = new int[nthFibonacciToGet+1]; // to store already calculted fibonacci's, array size is extra to handle 0th
            fibs[0] = 0;
            fibs[1] = 1;
            
            for(int index = 2; index <= nthFibonacciToGet; index++)
            {
                fibs[index] = fibs[index - 1] + fibs[index - 2];
            }
            return fibs[nthFibonacciToGet];
        }

        /// <summary>
        /// T.C. : O(n)
        /// S.C. : O(1)
        /// </summary>
        /// <param name="nthFibonacciToGet"></param>
        /// <returns></returns>
        public static int Fibonacci_SpaceOptimized(int nthFibonacciToGet)
        {
            int tempVar1 = 0, tempVar2 = 1, tempVar3 = 0;

            if (nthFibonacciToGet == 0) return tempVar1;

            for(int index = 2; index <= nthFibonacciToGet; index++)
            {
                tempVar3 = tempVar1 + tempVar2;
                tempVar1 = tempVar2;
                tempVar2 = tempVar3;
            }
            
            return tempVar2;
        }

        /// <summary>
        /// Works fine for upto 71, but from 72 it starts failing bcoz rounding error becomes significantly large
        /// T.C. : O(logn) as phi^nth takes logn time
        /// S.C. : O(1)
        /// </summary>
        /// <param name="nthFibonacciToGet"></param>
        /// <returns></returns>
        public static long Fibonacci_BinetFormula(int nthFibonacciToGet)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            return (long) Math.Round(Math.Pow(phi, nthFibonacciToGet) / Math.Sqrt(5));
        }
        #endregion

    }
}
