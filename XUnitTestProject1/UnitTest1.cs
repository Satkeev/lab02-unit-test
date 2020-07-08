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
            balance = 1000m;


            // Act
            decimal newBalanceAfterWithdraw = WithdrawFunds(50m);

            // Assert
            Assert.Equal(950m, newBalanceAfterWithdraw);
        }
    }
}
/// <summary>
/// Tests whether user can overdraw account
/// </summary>
[Fact]
public void CannotOverdrawAccount()
{
    // Arrange
    Program.balance = 500m;


    // Act
    decimal balanceAfterOverdraw = Program.WithdrawFunds(600m);


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
    balance = 1000m;


    // Act
    decimal newBalanceAfterDeposit = DepositFunds(200m);


    // Assert
    Assert.Equal(1200m, newBalanceAfterDeposit);
}
