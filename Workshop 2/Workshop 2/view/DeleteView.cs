using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.view
{
    class DeleteView : BaseView
    {
        public DeleteView(Database DAL) : base(DAL) { }

        public void Render()
        {
            Console.WriteLine("Input personal number.");
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

                    if (!_DAL.IsPersonalNumberTaken(personalNumber))
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

    }
}
