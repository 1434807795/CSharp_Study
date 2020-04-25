using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            string[] S;
            Fraction F = new Fraction();
            Fraction F0 = new Fraction();
            Fraction temF = new Fraction();
            Fraction resF = new Fraction();
            Console.WriteLine("请按“x/y”的形式输入您想输入的分数，例如：-5/75等。");
            F = F.Parse(Console.ReadLine());
            Console.WriteLine("您所输入的分数的最简形式为：");
            F.Print(F);
            Console.WriteLine("您所输入的分数所对应的小数值为：{0}",F.DecimalValue);
            Console.ReadKey();
            Console.WriteLine("请输入您想与之计算和比较的分数（只需一个），格式需要相同！");
            F0 = F0.Parse(Console.ReadLine());
            Console.WriteLine("----------下面是四则运算的结果----------");
            Console.WriteLine("{0} + {1} = {2}",F.ToString(),F0.ToString(), F + F0);
            Console.WriteLine("{0} - {1} = {2}",F.ToString(),F0.ToString(), F - F0);
            Console.WriteLine("{0} * {1} = {2}",F.ToString(),F0.ToString(), F * F0);
            Console.WriteLine("{0} ÷ {1} = {2}",F.ToString(),F0.ToString(), F / F0);
            Console.ReadKey();
            Console.WriteLine("----------下面是比较大小的结果----------");
            if (F > F0)
            {
                Console.WriteLine("{0} > {1}",F.ToString(),F0.ToString());
            }
            else if(F < F0)
            {
                Console.WriteLine("{0} < {1}",F.ToString(),F0.ToString());
            }
            else return;
            Console.ReadKey();
            Console.WriteLine("----------下面是字符串数组的操作----------");
            Console.WriteLine("请输入您想输入的分数个数：");
            int length = int.Parse(Console.ReadLine());
            S = new string[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("请输入您的第{0}个分数：",i+1);
                S[i] = Console.ReadLine();
                temF = temF.Parse(S[i]);
                result += temF.DecimalValue;
                resF += temF;
            }
            Console.WriteLine("----------输入完成----------");
            Console.WriteLine("您所输入的所有的分数的分数和为{0}，小数和为{1}。",resF.ToString(),result);
        }
    }
}
