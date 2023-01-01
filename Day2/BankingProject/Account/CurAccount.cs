namespace Account;
public class CurrentAccount : BankAccount
{
    private static string Type = "Current";

    public CurrentAccount(int balance) : base(balance)
    {

    }
    public CurrentAccount(){}
    public override void Transactions(int amount,BankAccount accountTranfer)
    {

        if (amount > base.Balance)
        {
            Console.WriteLine("Insufficent Funds");
        }
        base.Balance -= amount;
        Console.WriteLine("Amount Debited. Updated Balance of sender:" + base.Balance);

        accountTranfer.Balance += amount;
        Console.WriteLine("Amount Credited. Updated Balance of receiver :" + accountTranfer.Balance);

    }

    //   public override void Withdraw(int amount)
    // {
    //     if (amount > base.Balance)
    //     {
    //         Console.WriteLine("Insufficent Funds");
    //     }
    //     base.Balance -= amount;
    //     Console.WriteLine("Amount Debited. Updated Balance :" + base.Balance);
    // }

    // public override void Deposit(int amount)
    // {
    //     base.Balance += amount;
    //     Console.WriteLine("Amount Credited. Updated Balance :" + base.Balance);
    // }
}