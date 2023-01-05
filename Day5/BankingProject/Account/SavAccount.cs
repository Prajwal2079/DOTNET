namespace Account;
public class SavingAccount : BankAccount
{
    public SavingAccount(int balance, int accNo) : base(balance, accNo)
    {

    }
    public override void Withdraw(int amount)
    {
        if (amount > base.Balance)
        {
            Console.WriteLine("Insufficent Funds");
        }
        base.Balance -= amount;
        Console.WriteLine("Amount Debited. Updated Balance :" + base.Balance);
    }

    public override void Deposit(int amount)
    {
        base.Balance += amount;
        Console.WriteLine("Amount Credited. Updated Balance :" + base.Balance);
    }
}