using Accounts;
using ComplexNumbers;
using System.Collections.Generic;

Account account1 = new Account(5000);
Account account2 = new Account(5000);
Account account3 = new Account(3000);

(int num1, double num2, float num3) tuple = (45, 31728.123, 45.0f);
Console.WriteLine($"{tuple.num1}");

account1.Deposit(5000);
Console.WriteLine(account1.Balance);
Console.WriteLine("Enter amount");
double amount = Convert.ToDouble(Console.ReadLine());
account1.Balance = amount;
Console.WriteLine(account1.Balance);
// account1.Withdraw(100000);
account2.Withdraw(2000);

List<Account> bankAccounts = new List<Account>();
bankAccounts.Add(account1);
bankAccounts.Add(account2);
bankAccounts.Add(account3);

foreach(Account acc in bankAccounts){
    Console.WriteLine(acc.Balance);
}

Complex compNum1 = new Complex(20,30);
Complex compNum2 = new Complex(60,20);
Complex compNum3 = new Complex();
compNum3.Real = 60;
compNum3.Img = 60;
Console.WriteLine(compNum3.Real + " + "+ compNum3.Img+"i");


Complex result = compNum1 + compNum2;

Console.WriteLine(result.Real + " + "+ result.Img+"i");


