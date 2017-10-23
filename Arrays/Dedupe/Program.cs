using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedupe
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] nums = new int[5000];

            Random rand = new Random();
            int lowest = 10000;
            int highest = 0;
            int removed = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                nums[i] = rand.Next(0, 51);
                
            }

            Array.Sort(nums);
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(current != nums[i])
                {
                    current = nums[i];
                }
                else
                {
                    nums[i] = -1;
                }
                
            }
            Array.Sort(nums);

            for (int i=0;i<nums.Length;i++)
            Console.Write(nums[i] + ", ");
            Console.WriteLine("");
            
            


            
            


        }
    }
}
