using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_CA_ClassDsp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //类的实例化：创建对象的过程
            Hero hero1 = new Hero();//hero1:实例或者对象
            hero1.AddLife();//英雄闪亮登场
            Console.WriteLine("英雄的生命值为{0}",hero1.Life);//属性（Life）压轴出场了
        }
    }

    class Hero
    {
       //定义字段
        private string name;
        private int life;

        //定义属性：安全提升字段的功能
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Life
        {
            get { return life; } //不同的可访问性
            set
            {
                life = value < 0 ? 0 : (value > 100 ? 100 : value); //通过属性提供验证
            }
        }
        //定义普通方法
        public void AddLife()
        {
            life++;
        }
        //定义特殊方法---构造函数、析构函数
        public Hero()
        {
            name = "";
            life = 0;
        }
        ~Hero()
        {
            //C#自动回收垃圾，代码可以为空
        }
    }
}
