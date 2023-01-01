using Account;
namespace Membership;
public class Users
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }
    public BankAccount UserAccount{ get; set; }

    public Users(string username, string email, string contactnumber, BankAccount account)
    {
        UserName = username;
        Email = email;
        ContactNumber = contactnumber;
        UserAccount = account;
    }

    public override string ToString()
    {
        return $"Name: {UserName} Email:{Email} Number:{ContactNumber} {UserAccount}";
    }
}