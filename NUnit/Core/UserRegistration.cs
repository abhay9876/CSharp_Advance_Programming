/*Testing User Registration
Problem:
Create a UserRegistration class with:
● RegisterUser(string username, string email, string password).
● Throws ArgumentException for invalid inputs.
Write unit tests to verify valid and invalid user registrations.*/

using System;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrEmpty(username))
            throw new ArgumentException("Invalid UserName");

        if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            throw new ArgumentException("Invalid email");

        if (string.IsNullOrEmpty(password) || password.Length < 6)
            throw new ArgumentException("Invalid Password");
    }
}
