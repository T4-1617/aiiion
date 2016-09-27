using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanKing
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        private System.Collections.ArrayList accounts;

        public Customer()
        {
            accounts= new System.Collections.ArrayList();
        }

        public Account GetAccount(int AccountIndex)
        {
            return (Account)accounts[AccountIndex];
        }
        public System.Collections.ArrayList GetAccounts()
        {
            return accounts;
        }

        public void CreateAccount(decimal OpeningDeposit){
            if (OpeningDeposit >= 1000)
            {
                Account a = new Account();
                a.Deposit(OpeningDeposit);
                accounts.Add(a);
            }

        }
    }

    public class Account
    {
        private decimal balance;
        public string AccountName;
        public decimal Balance
        {
            get { return balance; }
        }
        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }
        public void Withdraw(decimal amount)
        {
            balance = balance - amount;
        }
    }
}
