using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Bank
    {
        private double balance;
        public Bank(double balance)
        {
            this.balance = balance;
        }
        public double gsBalance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        public void deposit(double money)
        {
            this.balance += money;
        }
        public void withdraw(double money)
        {
            this.balance -= money;
        }
        public String bankName()
        {
            return "TDBank";
        }
    }
}
