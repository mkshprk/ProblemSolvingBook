using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                BasicProblems.Print_Linearly_From_1_To_N_Striver(5);
                BasicProblems.Print_String_N_Times("str",5);
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                BasicProblems.Print_Linearly_From_1_To_N(5);
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                BasicProblems.Print_Linearly_From_N_To_1(5);
                */

                //double res = BasicProblems.Factorial(10); // 30*20
                //Console.WriteLine(res);
                //var reversedArray = BasicProblems.ReverseArrayUsing_2Pointers(new int[] { 1, 2, 3, 4, 2 }, 0);
                Console.WriteLine(BasicProblems.IsStringPalindrome_Recursion("madsm"));
                Console.WriteLine(BasicProblems.IsStringPalindrome_Recursion("madam"));
                Console.WriteLine(BasicProblems.IsStringPalindrome_Recursion(""));
                Console.WriteLine(BasicProblems.IsStringPalindrome_Recursion("madams"));
            }
            finally
            {
                Wait();
            }
        }



        private static void Wait()
        {
            Console.WriteLine("Press any key to Exit !!!");
            Console.ReadKey();
        }
    }
}
