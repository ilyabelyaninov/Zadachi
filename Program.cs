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
            int[] nums1 = { 0,1,2,3,4,5,6 };
            int[] nums2 = { 0, 1, 2};
            Random rnd = new Random();
            nums2 = rnd.Next(2, 5);
            for (int i = 0; i < nums1.Length; i++)
                Console.WriteLine(nums1 + nums2);

 
            Console.ReadKey();
        }
    }
}
