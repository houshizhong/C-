using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08_CA_AdvacedArrayDsp
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用方法，看看输出结果
            DspArray();

            DspSortArray();

        }

        //创建一个方法，演示使用Array类来创建数组的功能
        static void DspArray()
        {
           //创建了一个包含五个元素的整形数组
            Array intArray1 = Array.CreateInstance(typeof(int), 5);

            //对数组初始化
            for (int i = 0; i < intArray1.Length; i++)
                intArray1.SetValue(i+1,i);//第一个参数是元素的值；第二个参数是数组的下标

            //创建一个数组intArray2，演示复制数组的功能
            Array intArray2 = (int[])intArray1.Clone();

            //输出数组中的全部元素
            for (int i = 0; i < intArray2.Length; i++)
                Console.Write(intArray2.GetValue(i)+" ");
        }

        //创建一个方法，演示数组的快速排序:Ascii码
        static void DspSortArray()
        {
            string[] names =
            {
                "Jack","Tomces","Alges","Chigago"
            };

            Array.Sort(names);//对数组元素的升序排列

            foreach (string data in names)
                Console.Write(data+" ");

            //如何要降序输出元素的值应该怎么办？
        }
    }
}
