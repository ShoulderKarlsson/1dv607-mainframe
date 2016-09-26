using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.view
{
    abstract class BaseView
    {

        protected model.Database _DAL;

        protected BaseView(model.Database DAL)
        {
            _DAL = DAL;
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
            if (_DAL.IsPersonalNumberTaken(personalNumber))
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
    }
}
