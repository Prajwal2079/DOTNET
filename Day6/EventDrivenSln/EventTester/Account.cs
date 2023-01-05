namespace Banking;
using Governance;
public class Account{
    public event TaxOperations overBalance;
    public event BankManagerOperations underBalance;

    public double Balance { get; set; }
    public Account(double initialBalance){
        this.Balance = initialBalance;
    }
    public void Deposit(double amount){
        this.Balance += amount;
    }
    public void Withdraw(double amount){
        this.Balance -= amount;
        if(Balance <= 500){
            underBalance();
        }
    }
    public void ProcessTax(){
        if(this.Balance >=2500){  
            overBalance(Balance);    
        }
    }

    public override string ToString(){
        return $"Current Balance = {this.Balance}";
    }
}