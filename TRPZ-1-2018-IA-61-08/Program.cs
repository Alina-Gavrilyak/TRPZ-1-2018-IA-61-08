using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1_2018_IA_61_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,2,1 };
            SortetContainer.Sort(ref arr);
            Console.WriteLine();
            foreach(int i in arr)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
