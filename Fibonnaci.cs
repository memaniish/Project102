using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloProject102
{
    class Fibonnaci
    {
        public void FindFibonnaci()
        {
            Console.WriteLine("Please enter how many fibonnaci numbers you want");
            int number=Convert.ToInt32(Console.ReadLine());
            int first=0, second=1;
            int result=0;
            result = first + second;
            Console.Write("{0} {1} {2}",first, second, result);
            //0 1 1
            for(int i=2;i<=number; i++)
            {
                first = second; //first=1
                second = result; //second=1
                result=first+ second; //result=2
                Console.Write(" "+result);

            }
        }



    }
}
