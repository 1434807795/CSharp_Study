using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public abstract class Account
    {
        //字段
        #region
        public string _name;                       //姓名
        public double _balance;                    //余额
        public double _interestrate;               //利率
        public byte _accounttype;                  //账户类型，0为个人账户，1为企业账户
        public int _months;                        //存贷款时间
        #endregion
    }

    //存款账户
    public class DepositAccount : Account, IMyInterface
    {
        //字段
        #region
        new public string _name;                       //姓名
        new public double _balance;                    //余额
        new public double _interestrate;               //利率
        new public byte _accounttype;                  //账户类型，0为个人账户，1为企业账户
        new public int _months;                        //存贷款时间
        #endregion
        
        //属性
        #region
        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }

        public double Banlance
        {
            get{return _balance;}
            set{_balance = value;}
        }

        public double Interestrate
        {
            get{return _interestrate;}
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("利率必须大于0！");
                }
                else
                {
                    _interestrate = value;
                }
            }
        }

        public byte Accounttype
        {
            get{return _accounttype;}
            set
            {
                if (value != 1 || value != 0)
                {
                    Console.WriteLine("请输入正确的账户类型！（0为个人账户，1为企业账户）");
                }
                else
                {
                    _accounttype = value;
                }
            }
        }

        public int Months
        {
            get{return _months;}
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("存款时间必须大于1个月！");
                }
                else
                {
                    _months = value;
                }
            }
        }
        #endregion

        //方法
        #region
        //构造方法
        public DepositAccount(string name, byte accounttype)
        {
            this._name = name;
            this._balance = 0;
            this._interestrate = 0;
            this._accounttype = accounttype;
            this._months = 0;
        }

        //存款
        public void Deposit(double money)
        {
            this.Banlance += money;
        }

        //取款
        public void Withdraw(double money)
        {
            this.Banlance -= money;
        }

        //获得利息
        public double GetInterest(int time,double interestrate)
        {
            double interest = 0;
            if (this.Banlance < 1000)
            {
                Console.WriteLine("余额小于1000，没有利息！");
            }
            else
            {
                interest = this.Banlance * interestrate * time;
            }
            return interest;
        }
        #endregion
    }

    //贷款账户
    public class LoanAccount : Account, IMyInterface
    {
        //字段
        #region
        new public string _name;                       //姓名
        new public double _balance;                    //余额
        new public double _interestrate;               //利率
        new public byte _accounttype;                  //账户类型，0为个人账户，1为企业账户
        new public int _months;                        //存贷款时间
        #endregion
        
        //属性
        #region
        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }

        public double Banlance
        {
            get{return _balance;}
            set{_balance = value;}
        }

        public double Interestrate
        {
            get{return _interestrate;}
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("利率必须大于0！");
                }
                else
                {
                    _interestrate = value;
                }
            }
        }

        public byte Accounttype
        {
            get{return _accounttype;}
            set
            {
                if (value != 1 || value != 0)
                {
                    Console.WriteLine("请输入正确的账户类型！（0为个人账户，1为企业账户）");
                }
                else
                {
                    _accounttype = value;
                }
            }
        }

        public int Months
        {
            get{return _months;}
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("贷款时间必须大于1个月！");
                }
                else
                {
                    _months = value;
                }
            }
        }
        #endregion

        //方法
        #region
        //构造方法
        public LoanAccount(string name, byte accounttype)
        {
            this._name = name;
            this._balance = 0;
            this._interestrate = 0;
            this._accounttype = accounttype;
            this._months = 0;
        }

        //存款
        public void Deposit(double money)
        {
            this.Banlance += money;
        }
        
        //获得利息
        public double GetInterest(int time,double interestrate)
        {
            double interest = 0;
            if (this.Accounttype == 0)
            {
                if (time < 3)
                {
                    interest = 0;
                }
                else
                {
                    interest = this.Banlance * interestrate * (time - 3);
                }
            }
            else if (this.Accounttype == 1)
            {
                if (time < 2)
                {
                    interest = 0;
                }
                else
                {
                    interest = this.Banlance * interestrate * (time - 2);
                }
            }
            return interest;
        }
        #endregion
    }

    //抵押贷款账户
    public class MortgageAccount : Account, IMyInterface
    {
        //字段
        #region
        new public string _name;                       //姓名
        new public double _balance;                    //余额
        new public double _interestrate;               //利率
        new public byte _accounttype;                  //账户类型，0为个人账户，1为企业账户
        new public int _months;                        //存贷款时间
        #endregion
        
        //属性
        #region
        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }

        public double Banlance
        {
            get{return _balance;}
            set{_balance = value;}
        }

        public double Interestrate
        {
            get{return _interestrate;}
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("利率必须大于0！");
                }
                else
                {
                    _interestrate = value;
                }
            }
        }

        public byte Accounttype
        {
            get{return _accounttype;}
            set
            {
                if (value != 1 || value != 0)
                {
                    Console.WriteLine("请输入正确的账户类型！（0为个人账户，1为企业账户）");
                }
                else
                {
                    _accounttype = value;
                }
            }
        }

        public int Months
        {
            get{return _months;}
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("贷款时间必须大于1个月！");
                }
                else
                {
                    _months = value;
                }
            }
        }
        #endregion

        //方法
        #region
        //构造方法
        public MortgageAccount(string name, byte accounttype)
        {
            this._name = name;
            this._balance = 0;
            this._interestrate = 0;
            this._accounttype = accounttype;
            this._months = 0;
        }

        //存款
        public void Deposit(double money)
        {
            this.Banlance += money;
        }
        
        //获得利息
        public double GetInterest(int time,double interestrate)
        {
            double interest = 0;
            if (this.Accounttype == 0)
            {
                if (time < 6)
                {
                    interest = 0;
                }
                else
                {
                    interest = this.Banlance * interestrate * (time - 6);
                }
            }
            else if (this.Accounttype == 1)
            {
                if (time < 12)
                {
                    interest = this.Banlance * interestrate * time * 0.5;
                }
                else
                {
                    interest = this.Banlance * interestrate * (time - 12) + this.Banlance * interestrate * 12 * 0.5;
                }
            }
            return interest;
        }
        #endregion
    }
}
