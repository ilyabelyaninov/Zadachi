using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 2, 3, 4, 5, 6 };
            int[] nums2 = { 0, 1, 2 };
            Random rnd = new Random();
           
            int t = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine("Ученик №" + nums1[i]);
                int c = 0;
                for (int k = 0; k < nums2.Length; k++)
                {
                    nums2[k] = rnd.Next(2, 6);
                    Console.WriteLine(nums2[k]);
                    if (nums2[k] < 5)
                    {
                        c = c + 1;
                    }
                }
                if (c > 2)
                {
                    t = t + 1;
                }
            }
            Console.WriteLine("Количество учеников, не получивших 5 = " + t);
            Console.ReadKey();
        }
    }
}

