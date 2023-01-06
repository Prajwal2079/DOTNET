namespace UsersInformation;
[Serializable]
public class Users
{
    public Users(){
        
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string Password { get; set; }

    public Users(string fname,string lname,string email,string mobno,string password){
        this.FirstName = fname;
        this.LastName = lname;
        this.Email = email;
        this.MobileNumber = mobno;
        this.Password = password;
    }

}