using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10_CA_ClassDemo
{
    class Line
    {
        //成员变量本身是私有，其它的类无法访问，比较安全
        private double length;
        
        //构造函数跟类的名字一样
        public Line()
        {
            Console.WriteLine("对象已经创建");
        }
        //析构函数一般销毁资源使用，一般省略不写
        ~ Line()
        {
            Console.WriteLine("对象已经销毁");
        }

        //使用成员函数可以访问私有成员变量
        public void setLength(double len)
        {
            this.length = len;
        }

        public double getLength()
        {
            return length;
        }

        //使用属性来访问私有的成员变量
        public double Length
        {
            get { return length; }
            set { this.length = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();//当创建一个对象时，首先，调用构造函数
            line.setLength(4.3);
            Console.WriteLine("第一次运行的结果"+line.getLength());//成员函数

            line.Length = 5.4;
            Console.WriteLine("第二次运行的结果" + line.Length);//属性

            //当程序运行结束时，调用析构函数

            Console.ReadLine();
        }
    }
}
