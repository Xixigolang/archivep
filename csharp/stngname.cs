using System;

class Program
{
    static void Main()
    {
        Console.Write("请输入你的名字: ");
        string name = Console.ReadLine(); // 读取用户输入

        Console.WriteLine("你好, " + name + "!");
    }
}

//请输入你的名字: 小明
//你好, 小明!