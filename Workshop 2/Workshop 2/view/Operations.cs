using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.view
{
    class Operations
    {
        private string _opreation;

        public string GetOperation()
        {
            do
            {
                Console.WriteLine("Do something");
                Console.Write(" - ");
                _opreation = Console.ReadLine();
            } while (Console.ReadKey().Key != ConsoleKey.C);

            return _opreation;
        }
    }
}
