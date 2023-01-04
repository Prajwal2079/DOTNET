namespace Banking;
public delegate void BankManagerOperations();

public class BankManager {
    public void SendSMS(){
        Console.WriteLine($"SMS: Account balance too low");
    }
    public void SendEmail() {
        Console.WriteLine($"Email: Account balance too low");
    }
    public void BlockAccount() { 
        Console.WriteLine($"Account blocked.");
    }
}