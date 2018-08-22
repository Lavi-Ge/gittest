/***
 * 
 * 
 * 学习面向对象中的  方法   。
 * 
 * 
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestMethod
    {
        string strName;
        int intAge;


        //最简单方法：无参方法
        public void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo() 无参方法");
        }

        //带参方法
        public void DisplayInfo2(string name, int age)
        {
            Console.WriteLine("DisplayInfo1() 带参方法");
            Console.WriteLine("姓名={0}", name);
            Console.WriteLine("年龄={0}", age);
        }

        //返回类型为Int的数值
        public int GetAge(int age)
        {
                return age;
        }

        public static void Main()
        {
            TestMethod obj = new TestMethod();
            obj.DisplayInfo();       //使用无参方法
            obj.DisplayInfo2("小明",5);      //使用带参方法
            int intAge=obj.GetAge(20);
            Console.WriteLine("得到的年龄={0}", intAge);
        }
        
    }
}
