using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternsGenerator.Pattern5(3);
            WaitForUser();
        }
        static void WaitForUser()
        {
            Console.WriteLine("Press any Key To Exit");
            Console.ReadKey();
        }
    }
}
