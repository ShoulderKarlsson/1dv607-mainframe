using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.controller
{
    class MasterController
    {
        private controller.RegisterController _rController;
        private controller.DeleteController _dController;
        private controller.EditController _eController;
        private controller.ListController _lController;

        public void Init()
        {
            view.BaseUI bUI = new view.BaseUI();

            _rController = new RegisterController();
            _dController = new DeleteController();
            _eController = new EditController();
            _lController = new ListController();
            bUI.WelcomeMessage();

            do
            {
                switch (bUI.GetUserInput())
                {
                    case ConsoleKey.R:
                        _rController.CollectInformation();
                        break;
                    case ConsoleKey.D:
                        _dController.CollectInformation();
                        break;
                    case ConsoleKey.E:
                        _eController.CollectInformation();
                        break;
                    case ConsoleKey.L:
                        _lController.CollectInformation();
                        break;
                    case ConsoleKey.B:
                        _rController.CollectNewBoatInformation();
                        break;
                    case ConsoleKey.C:
                        _dController.DeleteBoat();
                        break;
                }

                Init();
            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}