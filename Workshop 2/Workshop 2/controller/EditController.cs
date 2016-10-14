using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class EditController : BaseController
    {
        private readonly EditView _eView;
        private Member _memberInfo;

        public EditController()
        {
            _eView = new EditView(_memberOperations);
        }

        public void CollectInformation()
        {
            _eView.Render();
            string personalNumber = _eView.GetUserPersonalNumber();
            _memberInfo = _memberOperations.GetUserInfo(personalNumber);
            _eView.PresentMemberInfo(_memberInfo);
            string choice = _eView.GetUserChoice();
            UpdateMemberInformation(choice);
        }

        private void UpdateMemberInformation(string choice)
        {
            switch (choice)
            {
                case "1":
                    string newName = _eView.EditName();
                    UpdateName(newName);
                    break;
                case "2":
                    //string pNumb = _eView.EditNumber();
                    string pNumb = _eView.GetUserPersonalNumber(true);
                    UpdatePersonalNumber(pNumb);
                    break;
                case "3":
                    _eView.PresentBoats(_memberInfo);
                    UpdateBoat(_memberInfo.MemberBoats.Count);
                    break;
            }
        }

        private void UpdatePersonalNumber(string newPn)
        {
            _memberOperations.UpdateUser(_memberInfo, newPn);
        }

        private void UpdateName(string name)
        {
            _memberInfo.Name = name;
            _memberOperations.UpdateUser(_memberInfo);
        }

        private void UpdateBoat(int amountOfBoats)
        {
            int boatID = _eView.ChooseBoat(amountOfBoats);
            int option = _eView.BoatEditOption();
            
            if (option == 1)
            {
                string type = _eView.GetBoatType();
                _memberOperations.EditBoatType(_memberInfo, boatID, type);
            }
            else
            {
                //BoatLength bl = _eView.GetBoatLength();

                string boatLength = _eView.GetBoatLength();


                // Will always be int, validation in BoatLength
                //_memberOperations.EditBoatLength(_memberInfo, boatID, int.Parse(bl.Length));

                _memberOperations.EditBoatLength(_memberInfo, boatID, boatLength);
            }
        }
    }
}
