using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.controller;
using Workshop_2.model;

namespace Workshop_2.view
{
    class RegisterView
    {

        private model.Database _DAL;
        public RegisterView(model.Database DAL)
        {
            _DAL = DAL;
        }

        public void RenderRegisterView()
        {
            Console.WriteLine("Enter information about new user.. =)");
        }

        public string GetUsername()
        {   

            string name = "";
            bool shouldLoop = true;

            do
            {
                Console.Write("Name: ");
                try
                {
                    name = Console.ReadLine();



                    if (name.Length < 2)
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

            return name;
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

                    if (_DAL.IsPersonalNumberTaken(personalNumber))
                    {
                        throw new Exception("That personal number is already registered, try again.");
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
