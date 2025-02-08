using System;

class Program
{
    static void Main()
    {
        Console.Write("请输入第一个数字: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); // 读取并转换为数字

        Console.Write("请输入运算符 (+, -, *, /): ");
        string op = Console.ReadLine(); // 读取运算符

        Console.Write("请输入第二个数字: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); // 读取并转换为数字

        double result = 0;
        if (op == "+")
            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else if (op == "*")
            result = num1 * num2;
        else if (op == "/")
        {
            if (num2 == 0)
                Console.WriteLine("错误：不能除以 0！");
            else
                result = num1 / num2;
        }
        else
            Console.WriteLine("错误：运算符无效！");

        Console.WriteLine("计算结果: " + result);
    }
}

//请输入第一个数字: 10
//请输入运算符 (+, -, *, /): *
//请输入第二个数字: 5
//计算结果: 50