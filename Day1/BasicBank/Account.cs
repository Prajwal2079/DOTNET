namespace Accounts;

public class Account{

    private double balance;

    public Account(){
        this.balance = 0;
    }

    public Account(double balance){
        this.balance = balance;
    }

    ~Account(){

    }

    public double Balance{
        get{return this.balance;}
        set{this.balance = value;}
    }

    public void Withdraw(double amount){
        if(amount == 0 || amount > this.balance){
            throw new Exception("Amount can not be 0");
        }
        this.balance -= amount;
        Console.WriteLine("Amount withdrawn. Balance : " + this.balance);
    }

    public void Deposit(double amount){
        if(amount < 0 || amount > this.balance){
            throw new Exception("Invalid amount");
        }
        this.balance += amount;
        Console.WriteLine("Amount deposited. Balance : " + this.balance);
    }
}