using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
           // rand.Next(0, 51);
            int[] n = new int[50];
            int dup = 0;
            for(int i=0;i<50;i++)
            {
                int num = rand.Next(1, 50);
                n[i] = num;


               {
                   Console.WriteLine(n[i] + "*");
               }


            }
            //
            
            for (int i = 0; i < 50; i++)
            {
                bool dupe = false;
                for (int j = 0; j < 50; j++)
                {
                    if (i != j)
                    {
                        if (n[i] == n[j])
                        {
                            dupe = true;
                        }
                    }

                }
                if (!dupe)
                    Console.WriteLine(n[i]);
                
            }




        }
    }
}
