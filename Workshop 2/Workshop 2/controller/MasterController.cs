using System;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class MasterController
    {
        private RegisterController _rController;
        private DeleteController _dController;
        private EditController _eController;
        private ListController _lController;

        public void Init()
        {
            BaseUI bUI = new view.BaseUI();

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