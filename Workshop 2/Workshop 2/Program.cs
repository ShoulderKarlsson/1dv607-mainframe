using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.view;

namespace Workshop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            view.Operations ops = new Operations();
            string operation = ops.GetOperation();

            Console.WriteLine(operation);
        }
    }
}
