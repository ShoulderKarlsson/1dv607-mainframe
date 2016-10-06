using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Workshop_2.model;

namespace Workshop_2.view
{
    class EditView : BaseView
    {
        public EditView(model.MemberOperations mOps) : base(mOps) { }

        public void Render()
        {
            ClearConsole();
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
                    CheckLength(personalNumber);
                    CheckAlreadyExists(personalNumber);

                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);
            return personalNumber;
        }

        protected override void CheckAlreadyExists(string personalNumber)
        {
            if (!_memberOps.IsPersonalNumberTaken(personalNumber))
            {
                throw new Exception("That user does not exist.");
            }
        }

        public string GetUserChoice()
        {
            Console.WriteLine("What would like to update? \n " +
                              "1. Name \n " +
                              "2. Personal Number \n " +
                              "3. Boat Information");

            return choiceValidation(3);
        }



        private string choiceValidation(int arg)
        {
            bool shouldLoop = true;
            string choice = "";
            do
            {

                try
                {
                    choice = Console.ReadLine();
                    int value;
                    bool isNumeric = int.TryParse(choice, out value);
                    if (!isNumeric || value > arg || value < 0)
                    {
                        throw new Exception("Invalid choice.");
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

        public string EditName()
        {
            Console.Write("New name:");
            return Console.ReadLine();
        }

        public int ChooseBoat(int amountOfBoats)
        {
            Console.Write("Select boat ID:");

            // Will always be int, validting in input method.
            return int.Parse(choiceValidation(amountOfBoats));
        }

        public int BoatEditOption()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1. Type");
            Console.WriteLine("2. Length");

            // Will always be int, validating in input method.
            return int.Parse(choiceValidation(2));
        }

        public string EditNumber()
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

                    if (_memberOps.IsPersonalNumberTaken(newPersonalNumber))
                    {
                        throw new Exception("That personal number is taken.");    
                    }

                    loop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (loop);

            return newPersonalNumber;
        }
        public void PresentBoats(Member member)
        {
            Console.WriteLine("Select ID of boat to edit");
            foreach (Boat boat in member.MemberBoats)
            {
                Console.WriteLine($"ID: {boat.ID}: {boat}");
            }
        }

        public void PresentMemberInfo(Member memberInfo)
        {
            Console.WriteLine(memberInfo.ToString());
        }
    }
}
