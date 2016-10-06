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

        public string EditName()
        {
            Console.Write("New name:");
            return Console.ReadLine();
        }

        public int ChooseBoat()
        {
            Console.Write("Select boat ID:");
            return int.Parse(Console.ReadLine());
        }

        public int BoatEditOption()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1. Type");
            Console.WriteLine("2. Length");
            return int.Parse(Console.ReadLine());
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
                        throw new Exception("That SSN is taken.");    
                    }
                    
                    //CheckAlreadyExists(newPersonalNumber);
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
