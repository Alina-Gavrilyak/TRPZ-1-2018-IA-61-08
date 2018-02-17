using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1_2018_IA_61_08
{
    public class SortetContainer
    {
        public enum SortName
        {
            MergeSort,
            QuickSort
        }

        static void Swap(ref int el1, ref int el2)
        {
            int tmp = el2;
            el2 = el1;
            el1 = tmp;
        }

        static public void Sort(ref int[] array, SortName sortName = SortName.MergeSort)
        {
            switch (sortName)
            {
                case SortName.MergeSort:
                    MergeSort(ref array);
                    break;
                case SortName.QuickSort:
                    QuickSort(ref array);
                    break;
                default:
                    Array.Sort(array);
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

        static public void QuickSort(ref int[] array)
        {
            QuickSort(ref array, 0, array.Length - 1);
        }
        static void QuickSort(ref int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(ref array, start, end);
            QuickSort(ref array, start, pivot - 1);
            QuickSort(ref array, pivot + 1, end);
        }
        static int Partition(ref int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end])
                {
                    Swap(ref array[marker], ref array[i]);
                    marker += 1;
                }
            }
            Swap(ref array[marker], ref array[end]);
            return marker;
        }
    }
}