using Banking.Domain;

namespace Banking.Tests;
public class MakingWithdrawals
{
    [Fact]
    public void MakingWithdrawalsDecreasesBalance()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 120.23M;

        account.withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}
