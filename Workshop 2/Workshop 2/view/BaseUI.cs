using System;

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
            Console.WriteLine("Press 'C' to delete boat");
            Console.WriteLine("Press 'E' to edit a member");
            Console.WriteLine("Press 'L' to list members");
            Console.WriteLine("Press 'B' to add boat");
        }


        public ConsoleKey GetUserInput()
        {
            return Console.ReadKey().Key;
        }
    }
}
