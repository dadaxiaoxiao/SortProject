using System;
using System.Collections.Generic;
using System.Text;

namespace SortingProjectCode.Sort
{
    class mergeSort
    {
        /*
            归并排序算法  
          
        */

        public  void MergeSort(int[] array)
        {
            int[] temp = new int[array.Length];
            MergeSort(array, 0, array.Length - 1, temp);
        }

        public static void MergeSort(int[] array, int first, int last, int[] temp)
        {
            if(first<last)
            {
                int mid = (first + last) / 2;
                MergeSort(array, first, mid, temp);
                MergeSort(array, mid+1, last, temp);
                Sort(array, first, mid, last, temp);

            }
        }
        public static void Sort(int[] array, int first, int mid, int last, int[] temp)
        {
            int i = first, j = mid + 1;
            int m = mid,    n = last;
            int k = 0;

            while(i<=m && j<=n)
            {
                if(array[i]< array[j])
                    temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
            }

             while(i<=m)
                temp[k++] = array[i++];
            while (j <= m)
                temp[k++] = array[j++];

            for (i = 0; i < k; i++)
                array[first + i] = temp[i];
        }

    }
}
