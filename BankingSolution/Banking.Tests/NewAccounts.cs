﻿

using Banking.Domain;

namespace Banking.Tests;
public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        // Write the code you wish you had
        // Given - I have a new account
        Account account = new Account();

        // when I ask it for it's balance
        decimal openingBalance = account.GetBalance();

        // then it's 5000 bucks. (decimal)
        Assert.Equal(5000M, openingBalance);
    }
}
