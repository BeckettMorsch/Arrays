using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            
                    System.Console.WriteLine("Min max");

                    int[] nums = new int[50];

                    Random rand = new Random();
                    int lowest = 10000;
                    int highest = 0;
                    for (int i = 0; i < nums.Length; i++)
                    {

                        nums[i] = rand.Next(0, 51);
                        // Console.Write(nums[i] + ",");
                    }


                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] < lowest)
                            lowest = nums[i];

                    }


                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] > highest)
                            highest = nums[i];
                    }






                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (i % 10 == 0)
                        {
                            Console.WriteLine("");
                        }

                        if (i != 49)
                            Console.Write(nums[i] + ",");
                        else
                            Console.Write(nums[i] + " \n  \n");
                    }
                    Console.WriteLine("min: " + lowest);
                    Console.WriteLine("max: " + highest);


                
            
        }
    }
}
