using System.Collections.Generic;
using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class ListController : BaseController
    {

        private readonly ListView _listView;

        public ListController()
        {
            _listView = new ListView(_memberOperations);
        }

        public void CollectInformation()
        {
            List<Member> memList = _DAL.GetMemberList();
            DisplayList(_listView.GetListChoice(), memList);
        }

        private void DisplayList(string choice, List<Member> users)
        {
            switch (choice)
            {
                case "1":
                    _listView.DisplayCompact(users);
                    break;
                case "2":
                    _listView.DisplayVerbose(users);
                    break;
                case "3":
                    DisplaySingleMember();
                    break;
            }
        }

        private void DisplaySingleMember()
        {
            string personalNumber = _listView.GetUserPersonalNumber();
            Member m = _memberOperations.GetUserInfo(personalNumber);
            _listView.DisplaySingleMember(m);
        }
    }
}
