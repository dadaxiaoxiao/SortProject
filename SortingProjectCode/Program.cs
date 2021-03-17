using System;
using SortingProjectCode.Sort;

namespace SortingProjectCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sourceArray = new int[] { 4, 2, 3, 6, 5, 8, 9, 1, 7 };

            // 1.冒泡排序算法
            //bubbleSort sort = new bubbleSort();
            //int[] resultArrary = sort.bubble_Sort(sourceArray);


            // 2.选择排序算法
            //selectSort sort = new selectSort();
            //int[] resultArrary = sort.select_Sort(sourceArray);


            //3.插入排序算法
            //insertSort sort = new insertSort();
            //int[] resultArrary = sort.insert_Sort(sourceArray);


            // 4.希尔排序
            shellSort sort = new shellSort();
            int[] resultArrary = sort.shell_Sort(sourceArray);


            for (int i = 0; i < resultArrary.Length; i++)
            {
                Console.WriteLine("index: " + resultArrary[i]);
            }
            Console.ReadKey();


        }


    }
}
