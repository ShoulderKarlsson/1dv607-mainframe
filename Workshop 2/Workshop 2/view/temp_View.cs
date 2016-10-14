using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.view
{
    class temp_View
    {
        public void Register()
        {
            Console.WriteLine("Register new member");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Personal Number: ");
            string personalNumber = Console.ReadLine();

        }





        private int NumberValidationInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    throw new Exception("Number validation error");
            }

            return int.Parse(input);
        }
    }
}
