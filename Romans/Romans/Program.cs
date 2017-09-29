using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int value;
            

            Console.Write("Enter your number:");
            value = Convert.ToInt16(Console.ReadLine());

            

            if (value == 1) 
            {
                Console.WriteLine("I");
            }

            if (value == 5)
            {
                Console.WriteLine("V");
            }

            if (value == 10)
            {
                Console.WriteLine("X");
            }

            if (value == 50)
            {
                Console.WriteLine("L");
            }

            if (value == 100)
            {
                Console.WriteLine("C");
            }

            if (value == 500)
            {
                Console.WriteLine("D");
            }

            if (value == 1000)
            {
                Console.WriteLine("M");
            }

            
          

            Console.ReadLine();
        }



    }
}
