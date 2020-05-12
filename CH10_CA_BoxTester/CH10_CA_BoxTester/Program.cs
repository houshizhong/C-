using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10_CA_BoxTester
{
    /// <summary>
    /// 最核心的封装：类
    /// 1、类=成员变量+成员函数
    /// </summary>
    class Box
    {
        //1、成员变量:private,是安全的
        private double length;
        private double breadth;
        private double height;

        //2、成员函数(方法)
        public void setLength(double len)
        {
            this.length = len;
        }
        public void setBreadth(double bth)
        {
            this.breadth = bth;
        }
        public void setHeight(double het)
        {
            this.height = het;
        }
        public double getVolumn()
        {
            return length * breadth * height;
        }
    }
    /// <summary>
    /// 在C#中的类的名跟文件名不存在物理对应
    /// </summary>
    class BoxTester
    {
        static void Main(string[] args)
        {
           // box1:对象
            Box box1 = new Box();
            double volumn;

            box1.setLength(2.0);
            box1.setBreadth(3.0);
            box1.setHeight(4.0);

            volumn = box1.getVolumn();

            Console.WriteLine("The volumn of the box is {0}",volumn);

        }
    }
}
