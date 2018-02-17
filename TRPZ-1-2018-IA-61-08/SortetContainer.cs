using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1_2018_IA_61_08
{
    public class SortetContainer
    {
        static void Swap(ref int el1, ref int el2)
        {
            int tmp = el2;
            el2 = el1;
            el1 = tmp;
        }

        public enum SortName
        {
            MergeSort
        }

        static public void Sort(ref int[] arr, SortName sortName = SortName.MergeSort)
        {
            //switch (sortName)
            //    case
        }
    }
}
