using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac1
{
    public class Account
    {
        private double balance;

        public Account(double initBalance)
        {
            balance = initBalance;
        }

        public double getBalance()
        {
            return balance;
        }

        public void deposit(double atm)
        {
            balance = balance + atm;
        }

        public void withdraw(double atm)
        {
            balance = balance - atm;
        }
    }
}