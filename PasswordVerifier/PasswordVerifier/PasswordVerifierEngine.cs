using System;
using System.Linq;
using static System.String;

namespace PasswordVerifier
{
    public class PasswordVerifierEngine
    {

        public static bool Verify(string userInputPassword)
        {
            if (!ContainsNullOrWhiteSpace(userInputPassword) && IsMinLength(userInputPassword) && IsMinUppercase(userInputPassword) && IsMinLowercase(userInputPassword) && IsMinDigits(userInputPassword))
            {
                Console.WriteLine("\nYour password has been accepted.");
                return true;
            }
            else
            {
                Console.WriteLine("\nYour password is invalid because:");
                if (ContainsNullOrWhiteSpace(userInputPassword)) Console.WriteLine("\t- Your password may not contain white space.");
                if (!IsMinLength(userInputPassword)) Console.WriteLine("\t- Your password must be at least nine characters long.");
                if (!IsMinUppercase(userInputPassword)) Console.WriteLine("\t- Your password must contain at least one uppercase letter.");
                if (!IsMinLowercase(userInputPassword)) Console.WriteLine("\t- Your password must contain at least one lowercase letter.");
                if (!IsMinDigits(userInputPassword)) Console.WriteLine("\t- Your password must contain at least one digit.");
                Console.WriteLine("Please try again.");
                return false;
            }
        }

        public static bool IsMinLength(string userInputPassword)
        {
            const int minLength = 9;
            return userInputPassword.Length >= minLength;
        }

        public static bool ContainsNullOrWhiteSpace(string userInputPassword)
        {
            if (IsNullOrWhiteSpace(userInputPassword)) return true;
            for (int i = 0; i < userInputPassword.Length; i++)
            {
                if (char.IsWhiteSpace(userInputPassword, i)) return true;
            }
            return false;
        }

        public static bool IsMinUppercase(string inputPassword)
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

        public static bool IsMinLowercase(string inputPassword)
        {
            const int minLowercase = 1;
            var countOfLowercase = 0;
            for (var i = 0; i < inputPassword.Length; i++)
            {
                if (!char.IsLower(inputPassword, i)) continue;
                countOfLowercase++;
                if (countOfLowercase == minLowercase) return true;
            }
            return false;
        }

        public static bool IsMinDigits(string inputPassword)
        {
            const int minDigits = 1;
            var countOfDigits = 0;
            for (var i = 0; i < inputPassword.Length; i++)
            {
                if (char.IsDigit(inputPassword, i))
                {
                    countOfDigits++;
                    if (countOfDigits == minDigits) return true;
                }
            }
            return false;
        }
    }
}