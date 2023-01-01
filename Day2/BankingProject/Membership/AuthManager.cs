namespace Membership;
public class AuthManager
{

    private static string username = "Suraj";
    private static string password = "suraj";

    public static bool Validate(string name, string pass)
    {
        return username == name && password == pass;
    }
}