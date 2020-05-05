using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    interface IMyInterface
    {
        string Name{get;set;}
        double Banlance{get;set;}
        double Interestrate{get;set;}

        //存款
        void Deposit(double money);
        //获得利息
        double GetInterest(int time,double interestrate);
    }
}
