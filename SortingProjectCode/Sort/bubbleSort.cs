using System;
using System.Collections.Generic;
using System.Text;

namespace SortingProjectCode.Sort
{
    class bubbleSort
    {
        /*
         冒泡排序算法  
         1.比较相邻的元素。如果第一个比第二个大，就交换他们两个
         2.对每一对相邻元素作同样的工作，从开始第一对到结尾的最后一对，这步做完后，最后的元素会是最大的数。
         3.针对所有的元素重复以上的步骤，除了最后一个 （外循环 n-1 次）
         4.内循环 n-i-1 次
         平均时间复杂度 O(n2) 空间复杂度 O(1) 稳定性
         */
        public int[] bubble_Sort(int[] sourceArray)
        {
            int[] arr = sourceArray;

            for (int i = 0; i < sourceArray.Length - 1; i++)  // 外循环 n-1 次
            {
                for (int j = 0; j < sourceArray.Length - i - 1; j++) // 内循环 n-i-1 次
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tempNumber = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempNumber;
                    }
                }
            }
            return arr;
        }
    }
}
