/*Testing Password Strength Validator
Problem:
Create a PasswordValidator class with:
● Passwords must have at least 8 characters, one uppercase letter, and one
digit.
Write unit tests for valid and invalid passwords.*/


using System;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (password.Length < 8)
            return false;

        bool hasUpper = password.Any(char.IsUpper);
        bool hasDigit = password.Any(char.IsDigit);

        return hasUpper && hasDigit;
    }
}
