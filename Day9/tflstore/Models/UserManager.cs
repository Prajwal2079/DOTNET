using System.Collections.Generic;
namespace tflstore.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class UserManager
{
    public static void SaveUser(User user)
    {
        List<User> userlist = GetAllUsers();
        userlist.Add(user);
        var usersJson = JsonSerializer.Serialize<List<User>>(userlist);
        File.WriteAllText("../tflstore/Data/Users.json", usersJson);
    }

    public static List<User> GetAllUsers()
    {
        string jsonString = File.ReadAllText("../tflstore/Data/Users.json");
        List<User> newUserlist = new List<User>();
        newUserlist = JsonSerializer.Deserialize<List<User>>(jsonString);
        return newUserlist;
    }

    public static User AuthenticateUser(User user)
    {
        List<User> userlist = GetAllUsers();
        foreach (User temp in userlist){
            if(temp.email == user.email && temp.password == user.password){
                return temp;
            }
        }
        return null;
    }
}