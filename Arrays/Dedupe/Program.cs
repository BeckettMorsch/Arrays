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
            int[] nums = new int[50];

            Random rand = new Random();
            int lowest = 10000;
            int highest = 0;
            int removed = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                nums[i] = rand.Next(0, 51);
                
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        //nums[i] = -1;
                        
                        removed++;
                    }
                }
            }
            Array.Sort(nums);

            for (int i=0;i<nums.Length;i++)
            Console.Write(nums[i] + ", ");
            Console.WriteLine("");

            int final = nums.Length - removed;






        }
    }
}
