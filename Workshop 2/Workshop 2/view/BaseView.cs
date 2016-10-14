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

        protected virtual void ClearConsole() => Console.Clear();

        public virtual string GetUserPersonalNumber(bool wantToCheckForBusyPersonalNumber = false)
        {
            ClearConsole();
            string personalNumber = "";
            bool shouldLoop = true;

            do
            {
                Console.Write("Personal Number: ");
                try
                {
                    personalNumber = Console.ReadLine();
                    NumberInputValidation(personalNumber);

                    if (wantToCheckForBusyPersonalNumber)
                    {
                        if (CheckAlreadyExists(personalNumber))
                            throw new Exception("Busy PersonalNumber");
                    }
                    else
                    {
                        if (!CheckAlreadyExists(personalNumber))
                            throw new Exception("No such personal number");
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

        protected virtual bool CheckAlreadyExists(string personalNumber) => _memberOps.IsPersonalNumberTaken(personalNumber);

        public string GetBoatType()
        {
            for (int i = 0; i < Enum.GetNames(typeof(BoatTypes)).Length; i++)
            {
                Console.WriteLine($"{i}: {Enum.GetName(typeof(BoatTypes), i)}");
            }

            do
            {
                Console.Write("Choose boat type: ");
                try
                {
                    int choice;
                    string value = Console.ReadLine();
                    if (!int.TryParse(value, out choice)) return Enum.GetName(typeof (BoatTypes), choice);
                    if (choice > Enum.GetNames(typeof(BoatTypes)).Length - 1 || choice < 0)
                        throw new Exception("That is not a valid choice");

                    return Enum.GetName(typeof(BoatTypes), choice);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (true);
        }

        public string GetBoatLength()
        {
            do
            {
                Console.Write("Boat Length: ");
                try
                {
                    string length = Console.ReadLine();
                    NumberInputValidation(length);
                    return length;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }

        protected void NumberInputValidation(string value)
        {
            if (value.Any(c => !char.IsDigit(c)))
                throw new Exception("Cannot contain letters.");

            if (value.Length == 0)
                throw new Exception("Cannot be empty!");
        }

        protected void StringInputValidation(string value)
        {
            if (value.Any(c => char.IsDigit(c)))
                throw new Exception("Cannot contain numbers.");

            if (value.Length == 0)
                throw new Exception("Cannot be empty!");
        }
    }
}
