using System;

namespace PasswordVerifier
{
    public class PasswordVerifierEngine
    {
        public PasswordVerifierEngine()
        {
        }

        public bool Verify(string userInputPassword)
        {
            if (IsMinLength(userInputPassword))
            {
                Console.WriteLine("Your password has been accepted.");
                return true;
            }
            Console.WriteLine("Please try again.");
            return false;
        }

        public static bool IsMinLength(string userInputPassword)
        {
            const int minLength = 9;
            return userInputPassword.Length >= minLength;
        }
    }
}