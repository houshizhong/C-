using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_CA_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您成绩的级别：");
            char grade = (char)Console.Read();
            switch(char.ToUpper(grade)) //小写字母转换为大写字母
            {
                case 'A':
                    Console.WriteLine("成绩的等级为：85-100分");
                    break;
                case 'B':
                    Console.WriteLine("成绩的等级为：70-84分");
                    break;
                case 'C':
                    Console.WriteLine("成绩的等级为：60-69分");
                    break;
                case 'D':
                    Console.WriteLine("成绩的等级为：<60分");
                    break;
                default:
                    Console.WriteLine("输入有误！");
                    break;
            }
        }
    }
}
