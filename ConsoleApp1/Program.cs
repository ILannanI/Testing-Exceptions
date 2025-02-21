
public class InvalidUsernameException : Exception
{
    public InvalidUsernameException(string message) : base(message) { }
}

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException(string message) : base(message) { }
}

public class UserValidator
{
    public void ValidateCredentials(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || username.Length < 5)
        {
            throw new InvalidUsernameException("Username must be at least 5 characters.");
        }

        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            throw new InvalidPasswordException("Password must be at least 8 characters.");
        }
    }
}
