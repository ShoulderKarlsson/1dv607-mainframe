﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.view
{
    class BaseUI
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the pirate club! aaarg");
            Console.WriteLine("##################################");
            Console.WriteLine("Choose what todo: ");
            Console.WriteLine("Press 'R' to register member");
            Console.WriteLine("Press 'D' to delete member");
            Console.WriteLine("Press 'E' to edit a member");
        }


        public ConsoleKey GetUserInput()
        {
            return Console.ReadKey().Key;
        }
    }
}
