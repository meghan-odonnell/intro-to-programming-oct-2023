﻿namespace Banking.Domain;

public class Account
{
    public Account()
    {
    }

    public void Deposit(decimal amountToDeposit)
    {
        throw new NotImplementedException();
    }

    public decimal GetBalance()
    {
        return 5000; // "slimed"
    }

    public void withdraw(decimal amountToWithdraw)
    {
        throw new NotImplementedException();
    }
}