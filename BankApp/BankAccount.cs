using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class BankAccount
    {
        private int _accountNumber;
        private string _accountHolder;
        private int _balance;
        public BankAccount(int n, string name, int b)
        {
            _accountNumber = n;
            _accountHolder = name;
            _balance = b;
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void withdraw(int amount)
        {
            if (Balance > amount)
                Balance -= amount;
        }
        public void deposit(int amount) { Balance += amount; }
    }
}
