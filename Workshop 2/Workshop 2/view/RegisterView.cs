using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.view
{
    class RegisterView
    {
        public void renderRegisterView()
        {
            Console.WriteLine("Enter information about new user.. =)");
        }

        public string GetUsername()
        {
            string username = "";
            bool shouldLoop = true;

            do
            {
                Console.Write("Name: ");
                try
                {
                    username = Console.ReadLine();
                    if (username.Length < 2)
                    {
                        throw new Exception("Name is to short!");
                    }
                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);

            return username;
        }

        public string GetUserPersonalNumber()
        {
            string personalNumber = "";
            bool shouldLoop = true;
            
            do
            {
                Console.Write("Personal Number: ");
                try
                {
                    personalNumber = Console.ReadLine();

                    foreach (char letter in personalNumber)
                    {
                        if (!char.IsDigit(letter))
                        {
                            throw new Exception("Can only be numbers in personal number.");
                        }
                    }



                    if (personalNumber.Length < 10)
                    {
                        throw new Exception("Personal Number must be 10 numbers long.");
                    }
                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);
            return personalNumber;
        }

    }
}
