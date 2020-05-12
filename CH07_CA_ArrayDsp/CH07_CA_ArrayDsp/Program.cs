using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07_CA_ArrayDsp
{
    class Program
    {
        static void Main(string[] args)
        {

            JCDim();



        }
        //1、一维数组的使用方法
        static void OneDim()
        {
            //方式1:先定义后初始化
            int[] array1;
            array1 = new int[] { 1, 2, 3, 4 };

            //方式2：定义和初始化一次性完成
            int[] array2 = new int[] { 1, 2, 3, 4 };

            //输出数组中的元素
            Console.Write(array1[0] + " " + array1[1] + " " + array1[2] + " " + array1[3]);

        }
        //2、二维数组的使用方法
        static void TwoDim()
        {
            int[,] array3 = new int[3, 3];
            array3[0, 2] = 5;

            int[,] array4 =
            {
                { 1,2,3},
                { 4,5,6},
                {7,8,9 }
            };

        }

        //3、锯齿数组的使用方法
        static void JCDim()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[4] { 3, 4, 5, 6 };
            jagged[2] = new int[3] { 7, 8, 9 };

            for (int row = 0; row < jagged.Length; row++)//外层的行数
            {
                for (int element = 0; element < jagged[row].Length; element++)//内层的元素数
                {
                    Console.WriteLine("row:{0}, element:{1},value:{2}", row, element, jagged[row][element]);
                }
            }
        }
    }
}
