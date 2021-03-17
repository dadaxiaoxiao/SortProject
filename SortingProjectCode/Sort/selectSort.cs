using System;
using System.Collections.Generic;
using System.Text;

namespace SortingProjectCode.Sort
{
    class selectSort
    {
        /* 选择排序
         1.首先在未排序序列中找到最小（大）元素，存放到排序序列的起始位置
         2.再从剩余未排序元素中继续寻找最小（大）元素，然后放到已排序序列的末尾 
         3.重复第二步，直到所有元素均排序完毕
         */
        public int[] select_Sort(int[] sourceArray)
        {
            int[] arr = sourceArray;
            // 总共需要N-1 轮比较
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                // 每轮需要比较的次数N-i
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        // 记录目前能找到的最小值元素的下标
                        min = j;
                    }
                }

                // 找到最小值下标和 i 位置所在值进行交换
                if (i != min)
                {
                    int tem = arr[i];
                    arr[i] = arr[min];
                    arr[min] = tem;
                }
            }
            return arr;
        }

    }
}
