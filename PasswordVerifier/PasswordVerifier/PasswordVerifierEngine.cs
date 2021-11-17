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

        public bool ShouldHaveOneUppercaseLetterAtLeast(string inputPassword)
        {
            const int minUppercase = 1;
            var countOfUppercase = 0;
            for (var i = 0; i < inputPassword.Length; i++)
            {
                if (char.IsUpper(inputPassword, i))
                {
                    countOfUppercase++;
                    if (countOfUppercase == minUppercase) return true;
                }
            }
            return false;
        }
    }
}