using System.Collections.Generic;

public static class UserStore
{
    // Stores user credentials separately
    public static Dictionary<string, string> UserPasswords = new Dictionary<string, string>(); // Username -> Password
    public static Dictionary<string, string> UserNames = new Dictionary<string, string>();     // Username -> Full Name
}
