using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloProject102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'M BATMAN");
            Console.ReadLine();
            Fibonnaci fibonnaci = new Fibonnaci();
            fibonnaci.FindFibonnaci();
            Console.ReadLine();
        }
    }
}
