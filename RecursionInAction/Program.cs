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
                Console.WriteLine(BasicProblems.Fibonacci_DP(5));
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
