namespace Account;
public class CurrentAccount : BankAccount
{
    public CurrentAccount(int balance, int accNo) : base(balance, accNo){}
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
}