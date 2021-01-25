using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{
   public class BankAccountBalanceCheck
    {
        [Fact]
        public void DebitAmount_10Rupees_AccountBalanceShouldBe10()
        {
            //Arrange
            string CustomerName = "Ramesh Kumar";
            double DebitAmount = 10;
            double balance = 10;
            //Act
            BankAccount account = new BankAccount("Ramesh Kumar",20);
            account.Debit(10);
            //Assert
            double accountBalance = account.Balance;
            Assert.Equal(accountBalance, balance);



        }
    }
}
