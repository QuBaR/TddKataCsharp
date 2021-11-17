using System;

namespace PasswordVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Password Verifier!");
            bool tryAgain = true;
            do
            {
                Console.WriteLine("\nYour password must contain the following:" +
                                  "\n\t- No white space characters" +
                                  "\n\t- At least 9 characters" +
                                  "\n\t- At least one uppercase letter" +
                                  "\n\t- At least one lowercase letter" +
                                  "\n\t- At least one digit");
                Console.Write("\nPlease enter your password: ");
                if (PasswordVerifierEngine.Verify(Console.ReadLine())) tryAgain = false;
            }
            while (tryAgain);
        }
    }
}
