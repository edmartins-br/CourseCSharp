using System;
using System.Collections.Generic;
using System.Text;
using BankAccount.Entities;

namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public double Ammount { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit, double ammount)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
            Ammount = ammount;
        }

        public double Deposit(double ammount)
        {
            return Balance += ammount;
        }

        public double Withdraw(double ammount)
        {
            if(ammount >= WithdrawLimit)
            {
                throw new DomainExceptions("-=-=-=-= The ammount exceeds the Withdraw Limit! -=-=-=-= ");
            }
            if(ammount > Balance)
            {
                throw new DomainExceptions("-=-=-=-= Your Balance isn't enough! -=-=-=-= ");
            }
            else
            {
                return Balance -= ammount;
            }
            

        }

        
    }
}
