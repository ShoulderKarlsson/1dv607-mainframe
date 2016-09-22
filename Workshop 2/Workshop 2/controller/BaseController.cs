using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.controller
{
    class BaseController
    {
        public void Init()
        {
            view.BaseUI bUI = new view.BaseUI();
            controller.RegisterController rController = new RegisterController();
            controller.DeleteController dController = new DeleteController();
            bUI.WelcomeMessage();
            do
            {
                switch (bUI.GetUserInput())
                {
                    case ConsoleKey.R:
                        Console.Clear();
                        rController.CollectInformation();
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        dController.CollectInformation();
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}