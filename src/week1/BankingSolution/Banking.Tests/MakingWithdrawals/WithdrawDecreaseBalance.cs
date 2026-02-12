
using Banking.Domain;

namespace Banking.Tests.MakingWithdrawals;

public class WithdrawDecreaseBalance
{
    [Fact]
    public void Example()
    {
        // Given a brand new account & get the opening balance
        var account = new Account();

        var openingBalance = account.GetBalance();
        var amountToWithdraw = 123.23M;

        // when i withdraw 123.23
        account.Withdraw(amountToWithdraw);


        // then the blance of the account should increase by that amount
        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    public void CanWithdrawFullBalance()
    {
        var account = new Account();
        account.Withdraw(account.GetBalance());
        Assert.Equal(0M, account.GetBalance());
    }

    [Fact]
    public void OverdraftIsUnbound()
    {
        // Given a brand new account & get the opening balance
        var account = new Account();

        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance*2;

        // when i withdraw 123.23
        account.Withdraw(amountToWithdraw);


        // then the blance of the account should increase by that amount
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void TransactionAmountsMustBeCorrect()
    {
        // deposit and withdrawal only allow aomunts that are > 0
        var account = new Account();

        var openingBalance = account.GetBalance();

        account.Withdraw(140.23M);
        account.Deposit(823.23M);
        account.Withdraw(-8450.23M);

        Assert.Equal(openingBalance, account.GetBalance());
    }
}
