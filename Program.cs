using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    class Account
    {
        private double _balance;
        public Account()
        {

        }
        public Account(double _balance)
        {
            this._balance = _balance;
        }
        public double Balance {
            set { _balance = value; }
            get { return _balance; }
        }
        public virtual bool Withdraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public void PrintBalance()
        {
            Console.WriteLine("balance: {0}", _balance);
        }
    }
    class SavingAccount : Account
    {
        private double intersetRate = 0.8;
        public SavingAccount() : base()
        {

        }
        public SavingAccount(double _balance) : base(_balance)
        {

        }
        public double InterestRate {
            set { intersetRate = value; }
            get { return intersetRate; }
        }
        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance) {
                Balance -= amount - amount * InterestRate;
                return true;
            }

            return false;
        }
        public override bool Deposit(double amount)
        {
            if (amount > 0) {
                Balance += amount + amount * InterestRate;
                return true;
            }

            return false;
        }
        class CheckingAccount : Account
        {
            public double InterestRate {
                get;
                private set;
            }
            public CheckingAccount() : base()
            {

            }
            public CheckingAccount(double amount)
            {

            }
            public override bool Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance) 
                {
                    Balance -= amount;
                    return true;
                }

                return false;
            }

            public override bool Deposit(double amount)
            {
                if (amount > 0) {
                    Balance += amount;
                    return true;
                }

                return false;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Account SAccount = new SavingAccount(5000);
                SAccount.Deposit(1000);
                SAccount.PrintBalance();
                SAccount.Withdraw(3000);
                SAccount.PrintBalance();

                Account CAccount = new CheckingAccount(5000);
                CAccount.Deposit(1000);
                CAccount.PrintBalance();
                CAccount.Withdraw(3000);
                CAccount.PrintBalance();
                Console.ReadLine();
            }
        }
    }
    }
