using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_testing_github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello world");
            myCoolFunction();
            Console.ReadKey();
        }

        static public void myCoolFunction()
        {
            Console.Write("I made a cool function");
        }
    }
}
