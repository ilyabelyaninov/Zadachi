using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 2, 3, 4, 5, 6 };
            int[] nums2 = { 0, 1, 2, 4 };
            Random rnd = new Random();
            double s = 0;
            int t = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine("Студент № " + nums1[i]);
                int c = 0;
                for (int k = 0; k < nums2.Length; k++)
                {
                    nums2[k] = rnd.Next(2, 6);
                    Console.WriteLine(nums2[k]);
                    s = s + nums2[k];
                    if (nums2[k] < 4)
                    {
                        c = c + 1;
                    }
                }
                if (c > 0)
                {
                    t = t + 1;
                }
      
            }
            double y = s / 28;
            Console.WriteLine("Количество неуспевающих студентов = " + t);

            Console.WriteLine("Средний балл группы = " + y);
            Console.ReadKey();
        }
    }
}

