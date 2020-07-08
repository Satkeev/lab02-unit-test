using System;
using Xunit;
using static lab02_unit_test.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// after withdrawal of funds balance test
        /// </summary>
        [Fact]
        public void checkBalanceWithdrawFunds()
        {
            // Arrange
            // account balance initialization that Program.WithdrawFunds below will use
            balance = 800m;


            // Act
            decimal newBalanceAfterWithdraw = WithdrawFunds(50m);

            // Assert
            Assert.Equal(750m, newBalanceAfterWithdraw);
        }


        /// <summary>
        /// user can overdraw account test
        /// </summary>
        [Fact]



        public void checkOverdrawAccount()
        {
            // Arrange
            balance = 400m;


            // Act
            decimal balanceAfterOverdraw = WithdrawFunds(500m);


            // Assert
            Assert.NotEqual(-100m, balanceAfterOverdraw);
        }


        /// <summary>
        /// after deposit tests whether can return updated balance
        /// </summary>
        [Fact]
        public void NewBalanceFromDepositFunds()
        {
            // Arrange
            balance = 800m;


            // Act
            decimal newBalanceAfterDeposit = DepositFunds(200m);


            // Assert
            Assert.Equal(1000m, newBalanceAfterDeposit);
        }

        /// <summary>
        /// User can deposit negative amount test
        /// </summary>
        [Fact]
        public void CantDepositNegativeAmount()
        {
            // Arrange 
            balance = 200m;


            // Act
            decimal balanceAfterNegativeDeposit = DepositFunds(-10m);


            // Assert testing
            Assert.NotEqual(190m, balanceAfterNegativeDeposit);
        }
    }
}
	


     


