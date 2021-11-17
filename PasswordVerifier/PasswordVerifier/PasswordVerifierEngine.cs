using System;
using System.Linq;
using static System.String;

namespace PasswordVerifier
{
    public class PasswordVerifierEngine
    {
        public bool Verify(string userInputPassword)
        {
            if (ContainsNullOrWhiteSpace(userInputPassword) && 
                IsMinLength(userInputPassword))
            {
                Console.WriteLine("Your password has been accepted.");
                return true;
            }
            Console.WriteLine("Please try again.");
            return false;
        }

        public bool IsMinLength(string userInputPassword)
        {
            const int minLength = 9;
            return userInputPassword.Length >= minLength;
        }

        public bool ContainsNullOrWhiteSpace(string userInputPassword)
        {
            if (IsNullOrWhiteSpace(userInputPassword)) return true;
            for (int i = 0; i < userInputPassword.Length; i++)
            {
                if (char.IsWhiteSpace(userInputPassword, i)) return true;
            }
            return false;
        }
    }
}