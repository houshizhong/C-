using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_CA_IO
{
    /// <summary>
    /// author:houshizhong
    /// datetime:2020.3.5 10:37
    /// funtion:这个类是第一讲的案例类
    /// </summary>
    class Program
    {
        #region 演示创建属性的创建属性的快捷键
        //演示创建属性的快捷键：Ctrl+R+E
        private double price;//字段：price

        // Price：属性
        public double Price { get => price; set => price = value; }//get ;set 访问器
        #endregion

        #region 这是主函数，是程序的入口
        static void Main(string[] args)
        {
            //开始写程序：Console类的用法
            string firstStr, secondStr;
            Console.Write("请输入第一个字符串");
            firstStr = Console.ReadLine();

            Console.Write("请输入第二个字符串");
            secondStr = Console.ReadLine();

            Console.WriteLine("第一个字符串是：{0} 第二个字符串你是：{1}",firstStr,secondStr);
        }
        #endregion

    }
}
