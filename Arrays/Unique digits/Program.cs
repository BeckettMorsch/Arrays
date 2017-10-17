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
            Random rand = new Random(System.Environment.TickCount);
            rand.Next(0, 51);
            int[] n = new int[50];
        
            for(int i=0;i<50;i++)
            {
                n[i] = rand.Next(0, 51);
            }

            for (int i = 0; i < 50; i++)
            {
                if(n[i]== )
            }




        }
    }
}
