using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //新建一个个人存款账户
            DepositAccount A = new DepositAccount("WHM",0);
            //存款
            A.Deposit(20000);
            //取款
            A.Withdraw(5000);
            //获得利息
            Console.WriteLine("您的利息为：{0}。",A.GetInterest(18,0.035));
            //新建一个企业贷款账户
            LoanAccount B = new LoanAccount("WH",1);
            //存款
            B.Deposit(20000);
            //获得利息
            Console.WriteLine("您的利息为：{0}。",B.GetInterest(27,0.037));
            //抵押贷款同理，此处不给出
        }
    }
}
