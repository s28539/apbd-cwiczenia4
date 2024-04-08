using System;

namespace LegacyApp;

public interface IUserValidator
{
    static bool EmailValidator(string email)
    {
        if (!email.Contains("@") && !email.Contains("."))
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    static bool NameValidator(string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static bool AgeValidator(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        int age = now.Year - dateOfBirth.Year;
        if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

        return age >= 21;
    }
}
