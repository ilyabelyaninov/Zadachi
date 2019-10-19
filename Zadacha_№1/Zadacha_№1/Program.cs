using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[4, 5];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            for (int k = 0; k < 5; k++)
                nums[i, k] = (i + k)*(i+k);
         
            foreach (int l in nums)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
    }
}
