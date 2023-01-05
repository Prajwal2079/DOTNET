using Membership;
using Account;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

class MainClass
{

    public static void Main(string[] args)
    {
        List<Users> userlist = new List<Users>();
        Console.WriteLine("Welcome");

        Console.WriteLine("Enter username and password. Admin");
        string username = Console.ReadLine();
        string password = Console.ReadLine();

        if (AuthManager.Validate(username, password))
        {
            string name;
            string email;
            string contactnumber;
            int balance;
            string type;
            int choice;
            int accountNo;
            int accNo;
            int amount;
            int sender;
            int receiver;
            string fileName = null;
            BankAccount account = null;
            CurrentAccount curAcc = new CurrentAccount();
            Console.WriteLine("Inside do while");
            do
            {
                Console.WriteLine("1.Register User 2.Transfer 3.Display Users 4.Withdraw amount 5.Deposit 6.Serialize data 7.DeSerialize data 8.Exit\nEnter your choice.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter username, email, contact number, opening balance, account Id and bank account type. \n");
                        name = Console.ReadLine();
                        email = Console.ReadLine();
                        contactnumber = Console.ReadLine();
                        balance = Convert.ToInt32(Console.ReadLine());
                        accNo = Convert.ToInt32(Console.ReadLine());
                        type = Console.ReadLine();
                        if (type == "Saving")
                        {
                            account = new SavingAccount(balance, accNo);
                        }
                        else
                        {
                            account = new CurrentAccount(balance, accNo);
                        }
                        Users user = new Users(name, email, contactnumber, account);
                        userlist.Add(user);
                        break;

                    case 2:
                        Console.WriteLine("Enter Senders account no, recivers account no and amount");
                        sender = Convert.ToInt32(Console.ReadLine());
                        receiver = Convert.ToInt32(Console.ReadLine());
                        amount = Convert.ToInt32(Console.ReadLine());
                        foreach (Users u1 in userlist)
                        {
                            if (u1.UserAccount.AccNo == sender)
                            {

                                if (u1.UserAccount.GetType() == curAcc.GetType())
                                {
                                    foreach (Users u2 in userlist)
                                    {
                                        if (u2.UserAccount.AccNo == receiver)
                                        {
                                            u1.UserAccount.Transactions(amount, u2.UserAccount);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Saving Account can not make Transaction");
                                }
                            }
                        }
                        break;

                    case 3:
                        foreach (var u in userlist)
                        {
                            Console.WriteLine(u);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter Account Number and amount");
                        accountNo = Convert.ToInt32(Console.ReadLine());
                        amount = Convert.ToInt32(Console.ReadLine());
                        foreach (Users u in userlist)
                        {
                            if (u.UserAccount.AccNo == accountNo)
                            {
                                u.UserAccount.Withdraw(amount);
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Enter Account Number and amount");
                        accountNo = Convert.ToInt32(Console.ReadLine());
                        amount = Convert.ToInt32(Console.ReadLine());
                        foreach (Users u in userlist)
                        {
                            if (u.UserAccount.AccNo == accountNo)
                            {
                                u.UserAccount.Deposit(amount);
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Enter filename: ");
                        var accountsJson = JsonSerializer.Serialize<List<Users>>(userlist);
                        fileName = Console.ReadLine();
                        File.WriteAllText(fileName, accountsJson);
                        break;

                    case 7:
                        Console.WriteLine("Enter filename: ");
                        fileName = Console.ReadLine();
                        string jsonString = File.ReadAllText(fileName);
                        List<Users> newUserlist = new List<Users>();
                        newUserlist = JsonSerializer.Deserialize<List<Users>>(jsonString);
                        userlist = newUserlist;
                        foreach (Users u in userlist)
                        {
                            Console.WriteLine($"{u.UserName} : {u.Email}");
                        }
                        break;

                    case 8:
                        Console.WriteLine("Thankyou");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 8);
        }
        else
        {
            throw new Exception("Invalid login credentials.");
        }
    }
}
