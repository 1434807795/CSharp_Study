using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class Fraction
    {
        //字段
        private int numerator;         //分子
        private int denominator;       //分母


        //属性
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                this.numerator = value;
            }
        }
        
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("分母不能为0！\n");
                }
                else if (value < 0)
                {
                    this.denominator = Math.Abs(value);
                    this.numerator = -1 * numerator;
                }
                else
                {
                    this.denominator = value;
                }
            }
        }

        public double DecimalValue
        {
            set { }
            get
            {
                return ((double)this.numerator / (double)this.denominator);
            }
        }


        //方法
        //构造方法,置初值为0
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        //辗转相除法即欧几里得算法化简分数
        //两个整数的最大公约数等于其中较小的那个数和两数相除余数的最大公约数。
        public static Fraction GCD(Fraction F)
        {
            int res = 0;
            int tmp = 0;
            int a = F.Numerator;
            int b = F.Denominator;
            if (a < b)
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            while (b != 0)
            {
                res = a % b;
                a = b;
                b = res;
            }
            res = a;                                       //求出最大公约数
            F.Numerator = F.Numerator / res;               //化简分子部分
            F.Denominator = F.Denominator / res;           //化简分母部分
            return F;
        }

        //运算符重载
        public static Fraction operator +(Fraction F1,Fraction F2)
        {
            Fraction tem = new Fraction();
            tem.Denominator = F1.Denominator * F2.Denominator;
            tem.Numerator = F1.Numerator * F2.Denominator + F1.Denominator * F2.Numerator;
            return GCD(tem);
        }
        public static Fraction operator -(Fraction F1,Fraction F2)
        {
            Fraction tem = new Fraction();
            tem.Denominator = F1.Denominator * F2.Denominator;
            tem.Numerator = F1.Numerator * F2.Denominator - F1.Denominator * F2.Numerator;
            return GCD(tem);
        }
        public static Fraction operator *(Fraction F1,Fraction F2)
        {
            Fraction tem = new Fraction();
            tem.Numerator = F1.Numerator * F2.Numerator;
            tem.Denominator = F1.Denominator * F2.Denominator;
            return GCD(tem);
        }
        public static Fraction operator /(Fraction F1,Fraction F2)
        {
            Fraction tem = new Fraction();
            tem.Numerator = F1.Numerator * F2.Denominator;
            tem.Denominator = F1.Denominator * F2.Numerator;
            return GCD(tem);
        }
        
        //比较运算符重载
        public static bool operator <(Fraction F1,Fraction F2)
        {
            return F1.DecimalValue < F2.DecimalValue;
        }
        public static bool operator >(Fraction F1,Fraction F2)
        {
            return F1.DecimalValue > F2.DecimalValue;
        }

        //重载ToString方法
        public override string ToString()
        {
            return this.Numerator + "/" + this.Denominator;
        }

        //定义Parse方法
        public Fraction Parse(string S)
        {
            Fraction tem = new Fraction();
            string[] str = S.Split('/');
            tem.Numerator = int.Parse(str[0]);
            tem.Denominator = int.Parse(str[1]);
            return GCD(tem);
        }

        //定义输出函数
        public void Print(Fraction F)
        {
            Console.WriteLine(GCD(F));
        }
    }
}
