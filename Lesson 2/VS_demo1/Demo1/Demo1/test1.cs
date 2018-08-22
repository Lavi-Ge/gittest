/***
 * 学习访问修饰符
 * 1.public     公共的
 * 2.private    私有的
 * 
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Test1
{
    public int intAge = 30;                //年龄
    private char chGender = 'M';        //性别


    public void DisplayTestClass()
    {
        Console.WriteLine("显示Test1中的内容");
    }
}
