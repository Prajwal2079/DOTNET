namespace tflstore.Models;

public class User {
   
    private string Name;
    private string Number;
    private string Email;
    private string Password;

    public User(){
    }

    public User(string email, string password){
        this.Email = email;
        this.Password = password;
    }

    public User(string name, string number, string email, string password){
        this.Name = name;
        this.Number = number;
        this.Email = email;
        this.Password = password;
    }

    //Properties of Product Entity
    public string name{
        get { return Name; }
        set { Name = value; }
    }
    
    public string number{
            get { return Number; }
            set { Number = value; }
    }

    public string email{
        get { return Email; }
        set { Email = value; }
    }
        
    public string password{
        get { return Password; }
        set { Password = value; }
    }
}