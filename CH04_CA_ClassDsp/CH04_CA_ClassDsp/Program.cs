using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_CA_ClassDsp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    //从这里构建一个银行账户类
    class Account//类名
    {
        //定义类中的字段：id,pwd,money
        private string id;
        private string pwd;
        private double money;
        //通过构造函数初始化类
        public Account(string _id, string _pwd, double _money)
        {
            this.id = _id;
            this.pwd = _pwd;
            this.money = _money;
        }
        //定义几个访问字段的公共方法
        public string getId()  //读方法
        {
            return id;
        }
        public void setId(string _id) //写方法
        {
            this.id = _id;
        }
    } 
}
