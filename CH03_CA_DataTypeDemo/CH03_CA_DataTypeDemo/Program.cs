using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_CA_DataTypeDemo //名字空间：namespace
{
    class ENumProgram //类：class
    {
        //定义一个枚举类型
        enum Gender
        {
            男,
            女
        };

        static void Main(string[] args)
        {
            //装箱：存储数据
            object obj;
            obj = 100;
            //拆箱：取走数据
            int data = (int)obj;
           // Console.Write(data);

            //演示字符串类型
           // string str = "C:\Windows"; 两种解决方案
           string str1= "C:\\Windows"; //  \\告诉编译器表示路径
           string str2 = @"C:\Windows";

            //演示枚举类型的使用方法
            int GenderNan =(int)Gender.男;  // 0
            int GenderNv = (int)Gender.女;  // 1

            Console.WriteLine(GenderNan);
            Console.WriteLine(Gender.男);

        }
    }
}
