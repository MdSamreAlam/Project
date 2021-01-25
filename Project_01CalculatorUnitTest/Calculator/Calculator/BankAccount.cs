using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        public BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                Console.WriteLine("you don't have sufficient balane to Debit amount");
                Console.ReadLine();
            }

            if (amount < 0)
            {
                Console.WriteLine("please Enter amount more than 0");
                Console.ReadLine();
            }

            m_balance -= amount; 
        }

        public void Credit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(" Please Enter amount Greater than 0 Like 100,200 so on to deposit in account");
                Console.ReadLine();
            }

            m_balance += amount;
        }
    }
}
