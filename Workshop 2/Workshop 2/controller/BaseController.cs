using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.controller
{
    class BaseController
    {
        private controller.RegisterController _rController;
        private controller.DeleteController _dController;
        private controller.EditController _eController;
        private controller.ListController _lController;
        private controller.AddBoatController _abController;

        public void Init()
        {
            view.BaseUI bUI = new view.BaseUI();
            _rController = new RegisterController();
            _dController = new DeleteController();
            _eController = new EditController();
            _lController = new ListController();
            _abController = new AddBoatController();
            bUI.WelcomeMessage();

            do
            {
                switch (bUI.GetUserInput())
                {
                    case ConsoleKey.R:
                        Console.Clear();
                        _rController.CollectInformation();
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        _dController.CollectInformation();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        _eController.CollectInformation();
                        break;
                    case ConsoleKey.L:
                        Console.Clear();
                        _lController.CollectInformation();
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        _abController.CollectInformation();
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        _dController.DeleteBoat();
                        break;
                }

                Init();
            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}