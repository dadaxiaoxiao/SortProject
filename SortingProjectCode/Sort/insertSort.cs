using System;
using System.Collections.Generic;
using System.Text;

namespace SortingProject
{
    class insertSort
    {
        /*
        插入排序算法  
        1.将第一待排序序列第一个元素看做一个有序序列，把第二个元素到最后一个元素当成是未排序序列
        2.从头到尾依次扫描未排序序列，将扫描到的每个元素插入有序序列的适当位置。
        （如果待插入的元素与有序序列中的某个元素相等，则将待插入元素插入到相等元素的后面。）
        */
        public int[] insert_Sort(int[] sourceArray)
        {
            int[] arr = sourceArray;
            // 第一个元素看做一个有序序列 , 从 下标 1 开始
            for (int i = 1; i < arr.Length; i++)
            {
                // 记录要插入的数据
                int tmp = arr[i];
                // 从已经排序的序列最右边的开始比较，找到比其小的数
                int j = i;
                while (j > 0 && tmp < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                if (j != i)
                {
                    arr[j] = tmp;
                }
            }
            return arr;
        }

    }
}
