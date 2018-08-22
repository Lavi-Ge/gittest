/***
 * 
 * 学习面向对象
 *   学习构造函数
 * 构造函数的特点：
 *   1.方法名称与类名称相同
 *   2.方法没有返回数值
 *   3.方法自动运行，无需显示调用
 * 
 * 构造函数的目的：
 *  1.给字段赋予初始值(初始化字段数值）
 * 
 * 字段的特点：
 *  1.如果没有添加初始数值，系统默认添加数值
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //定义字段
        private string strName;
        private int intAge;

        //特殊方法：构造函数
        //作用给字段赋值，初始化字段数值



        //Program()
        //{
        //    strName = "张三";
        //    intAge = 23;
        //    Console.WriteLine("我是构造函数");
        //    
        //}

        Program(string name,int age)
        {
            strName=name;
            intAge=age;
        }





        //定义方法
       public   void  DisplayInfo()
        {
            Console.WriteLine("这是一个DisplayInfo()方法");
            Console.WriteLine("名称={0},年龄={1}", strName, intAge);


        }

        public void DisplayInfo1(string str1,int intAge)
        {

        }


        static void Main1(string[] args)
        {

            //实例化对象（对象名称是obj）
            Program obj = new Program("张三",12);
            //调用方法
            obj.DisplayInfo();



        }
    }
}
