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
                IntermediateProblems.PrintAllSubSequences(0, new List<int>() { 5, 1, 2}, new List<int>());
                Console.WriteLine($"Number of sub-sequences generated are: {IntermediateProblems.howManySubSequencesGenerated}");
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
