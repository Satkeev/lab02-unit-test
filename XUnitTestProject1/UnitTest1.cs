using System;
using Xunit;
using static lab02_unit_test.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests whether can return updated balance after withdrawal of funds
        /// </summary>
        [Fact]
        public void checkBalanceWithdrawFunds()
        {
            // Arrange
            // Set initial account balance that Program.WithdrawFunds below will use
            balance = 800m;


            // Act
            decimal newBalanceAfterWithdraw = WithdrawFunds(50m);

            // Assert
            Assert.Equal(750m, newBalanceAfterWithdraw);
        }


        /// <summary>
        /// Tests whether user can overdraw account
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
        /// Tests whether can return updated balance after deposit
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
        /// Tests whether user can deposit negative amount
        /// </summary>
        [Fact]
        public void CantDepositNegativeAmount()
        {
            // Arrange
            balance = 200m;


            // Act
            decimal balanceAfterNegativeDeposit = DepositFunds(-10m);


            // Assert
            Assert.NotEqual(190m, balanceAfterNegativeDeposit);
        }
    }
}
	


     


