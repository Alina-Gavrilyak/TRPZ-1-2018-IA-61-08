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
            switch (sortName)
            {
                case SortName.MergeSort:
                    MergeSort(ref arr);
                    break;
            }
        }

        static public void MergeSort(ref int[] items)
        {
            if (items.Length <= 1)
            {
                return;
            }

            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];
            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);
            Sort(ref left);
            Sort(ref right);
            Merge(ref items, left, right);
        }

        static private void Merge(ref int[] items, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;
            int remaining = left.Length + right.Length;
            while (remaining > 0)
            {
                if (leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }
                else if (rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else
                {
                    items[targetIndex] = right[rightIndex++];
                }

                targetIndex++;
                remaining--;
            }
        }
    }
}