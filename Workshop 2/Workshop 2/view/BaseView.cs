using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Workshop_2.model;

namespace Workshop_2.view
{
    abstract class BaseView
    {

        protected model.MemberOperations _memberOps;

        protected BaseView(model.MemberOperations mOps)
        {
            _memberOps = mOps;
        }

        public virtual string GetUserPersonalNumber()
        {
            string personalNumber = "";
            bool shouldLoop = true;

            do
            {
                Console.Write("Personal Number: ");
                try
                {
                    personalNumber = Console.ReadLine();

                    CheckIfLetters(personalNumber);
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

        protected void CheckLength(string personalNumber)
        {
            if (personalNumber.Length != 10)
            {
                throw new Exception("Personal Number must be 10 numbers long.");
            }
        }

        protected virtual void CheckAlreadyExists(string personalNumber)
        {
            if (_memberOps.IsPersonalNumberTaken(personalNumber))
            {
                throw new Exception("That personal number is already registered, try again.");
            }
        }
        protected void CheckIfLetters(string personalNumber)
        {
            foreach (char letter in personalNumber)
            {
                if (!char.IsDigit(letter))
                {
                    throw new Exception("Can only be numbers in personal number.");
                }
            }
        }

        public string GetBoatType()
        {
            for (int i = 0; i < Enum.GetNames(typeof(BoatTypes)).Length; i++)
            {
                Console.WriteLine($"{i}: {BoatTypes.GetName(typeof(BoatTypes), i)}");
            }

            do
            {
                Console.Write("Choose boat type: ");
                try
                {
                    int choice;
                    string value = Console.ReadLine();
                    if (int.TryParse(value, out choice))
                    {
                        if (choice > Enum.GetNames(typeof(BoatTypes)).Length - 1 || choice < 0)
                        {
                            throw new Exception("That is not a valid choice");
                        }
                    }

                    return BoatTypes.GetName(typeof(BoatTypes), choice);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (true);
        }
        public BoatLength GetBoatLength()
        {
            do
            {
                Console.Write("Boat Length: ");

                try
                {
                    return new BoatLength(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (true);
        }
    }
}
