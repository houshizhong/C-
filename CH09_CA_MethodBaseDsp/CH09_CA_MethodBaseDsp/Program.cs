using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH09_CA_MethodBaseDsp
{
    class NumberManipulator
    {
        //实例方法
        public int FindMaxNum(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        //静态方法
        public static void ShowNum(int num)
        {
            Console.WriteLine("你要输出的结果是{0}",num);
        }

        //作业1：创建一个实例方法，计算三个数中的最大值


        //作业2：创建一个实例方法，计算n个数中的最大值:数组和循环

    }
    class Program
    {
        static void Main(string[] args)
        {
            //调用一个实例方法（对象）
            NumberManipulator mani = new NumberManipulator(); 
            int reslut=mani.FindMaxNum(12,23);//对象名.方法名
            //调用一个静态方法
            NumberManipulator.ShowNum(reslut);  //类名.方法名

           
        }
    }
}
