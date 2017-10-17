using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] w = new String[100];

            for(int i= 0; i < 100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    w[i] = i + ". " + "FizzBuzz";

                else if (i % 3 == 0)
                    w[i] = i + ". " + "Fizz";

                else if (i % 5 == 0)
                    w[i] = i + ". " + "Buzz";
                else
                    w[i] = i + ". ";

            }
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(w[i]);
            }
            


        }
    }
}
