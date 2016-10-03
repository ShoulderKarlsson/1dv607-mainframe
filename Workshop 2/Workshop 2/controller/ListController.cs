using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.controller
{
    class ListController
    {

        private readonly model.Database _DAL;
        private readonly model.MemberOperations _memberOps;
        private readonly model.MemberCatalog _memberCat;
        private readonly view.ListView _listView;

        public ListController()
        {
            _DAL = new Database();
            model.MemberCatalog mOps = new MemberCatalog(_DAL);
            _memberOps = new MemberOperations(mOps, _DAL);
            _listView = new view.ListView(_memberOps);
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
            model.Member m = _memberOps.GetUserInfo(personalNumber);
            _listView.DisplaySingleMember(m);
        }
    }
}
