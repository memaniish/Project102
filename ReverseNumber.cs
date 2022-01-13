using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloProject102
{
    class ReverseNumber
    {
        public static void FindReverseNumber()
        {
            Console.WriteLine("Please enter number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());//123//321
            int reminder = 0,reverse=0;
            while(number > 0)
            {
                reminder=number % 10;//3 2
                reverse = reverse*10+reminder;//3+2=5//3*10=30+2=32
                number = number / 10;  //12

            }
            Console.WriteLine("After reverse:" + reverse);

        }
    }
}
