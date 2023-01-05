namespace Account;
[Serializable]
public class BankAccount
{
    public int AccNo { set; get; }
    public int Balance { set; get; }

    // public BankAccount()
    // {
    //     Balance = 0;
    //     AccNo = 0;
    // }
    public BankAccount(int balance, int accNo)
    {
        Balance = balance;
        AccNo = accNo;
    }

    public override string ToString()
    {
        return $"Accno: {AccNo} Balance: {Balance} Type: {this.GetType()}";
    }

    public virtual void Withdraw(int amount) { }
    public virtual void Deposit(int amount) { }

    public virtual void Transactions(int amount, BankAccount accountTranfer) { }
}