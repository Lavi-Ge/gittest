/**
 * 
 * 
 * 学习面向对象中的“类”与“对象”
 * 1.定义字段、定义方法
 * 2.定义“方法”
 * 
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    //定义字段
    string strName = "张三";                               //姓名
    int intAge = 23;                                       //年龄 

    //定义方法
    void DisplayInfo()
    {
        Console.WriteLine("姓名={0}，年龄={1}", strName, intAge);  
    }


    static void Main(string[] args)
    {
        ////Program 是类，而obj是对象
        //Program obj = new Program();                       //实例化对象
        //obj.DisplayInfo();

        Test1 obj = new Test1();
        obj.DisplayTestClass();
        Console.WriteLine(obj.intAge);
    } 
}

