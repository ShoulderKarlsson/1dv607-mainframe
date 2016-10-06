using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.controller
{
    class ListController : BaseController
    {

        private readonly view.ListView _listView;

        public ListController()
        {
            _listView = new view.ListView(_memberOperations);
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
                    DisplaySingleMember(users);
                    break;
            }
        }

        private void DisplaySingleMember(List<Member> users)
        {
            string personalNumber = _listView.GetUserPersonalNumber();
            model.Member m = _memberOperations.GetUserInfo(personalNumber);
            _listView.DisplaySingleMember(m);
        }
    }
}
