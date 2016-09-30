using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.view
{
    class EditView : BaseView
    {
        public EditView(model.MemberOperations mOps) : base(mOps) { }

        public void Render()
        {
            Console.WriteLine("Enter personal number for the person to edit: ");
        }
        public override string GetUserPersonalNumber()
        {
            string personalNumber = "";
            bool shouldLoop = true;

            do
            {
                Console.Write("Personal Number: ");
                try
                {
                    personalNumber = Console.ReadLine();

                    if (personalNumber.Length < 10)
                    {
                        throw new Exception("Personal Number must be 10 numbers long.");
                    }

                    if (!_memberOps.IsPersonalNumberTaken(personalNumber))
                    {
                        throw new Exception("That user does not exist.");
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

        public string GetUserChoice()
        {

            string choice = "";
            bool shouldLoop = true;
            Console.WriteLine("What would like to update? \n " +
                              "1. Name \n " +
                              "2. Personal Number \n " +
                              "3. Boat Information");
            do
            {
                Console.Write(": ");
                try
                {
                    choice = Console.ReadLine();

                    int number;
                    bool isNumeric = int.TryParse(choice, out number);

                    if (!isNumeric || number > 3 || number <= 0)
                    {
                        throw new Exception("Invalid Choice.");
                    }
                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);

            return choice;
        }

        public string EditName(string personalNumber)
        {
            Console.Write("New name:");
            return Console.ReadLine();


        }
        public string EditNumber(string personalNumber)
        {
            string newPersonalNumber = "";
            bool loop = true;
            do
            {
                Console.Write("New personal number: ");
                try
                {
                    newPersonalNumber = Console.ReadLine();
                    CheckIfLetters(newPersonalNumber);
                    CheckLength(newPersonalNumber);
                    CheckAlreadyExists(newPersonalNumber);
                    loop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (loop);

            return newPersonalNumber;
        }
        public void EditBoat(string personalNumber)
        {
            Console.WriteLine("Boat");
        }

        public void PresentMemberInfo(Member memberInfo)
        {
            Console.WriteLine(memberInfo.ToString());
        }
    }
}
