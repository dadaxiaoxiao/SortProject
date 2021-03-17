using System;
using System.Collections.Generic;
using System.Text;

namespace SortingProjectCode.Sort
{
    class shellSort
    {
        /* 希尔排序 
         1.先将整个待排元素序列切割成若干个子序列（由相隔某个“增量”的元素组成的）分别进行直接插入排序
         2.然后依次缩减增量再进行排序
         3.待整个序列中的元素基本有序（增量足够小）时，再对全体元素进行一次直接插入排序
          增量的选择：在每趟的排序过程都有一个增量，至少满足一个规则 增量关系 d[1] > d[2] > d[3] >..> d[t] = 1 
         */
        public int[] shell_Sort(int[] sourceArry)
        {
            int[] arr = sourceArry;

            // d[1] > d[2] > d[3] >..> d[t] = 1    必须小于arr size
            int gap = 1;
            while(gap <arr.Length)
            {
                /* 计算首次步长 */
                gap = 3 * gap + 1;
            }
            while (gap >0)
            {
                for(int i = gap;i<arr.Length;i++)
                {
                    // 直接插入排序
                    int tmp = arr[i];
                    int j = i-gap;
                    while (j > 0 && tmp < arr[j])
                    {
                        arr[j+gap] = arr[j];
                        j -= gap;
                    }

                   
                     arr[j+ gap] = tmp;
                    
                }

                /* 计算下一轮步长 */
                gap = (int)Math.Floor(gap / 3.0);

            }

            return arr;
        }



    }
}
