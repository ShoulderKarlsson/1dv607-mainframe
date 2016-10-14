using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class DeleteController : BaseController
    {
        private readonly DeleteView _dView;
        private Member _member;

        public DeleteController()
        {
            _dView = new DeleteView(_memberOperations);
        }

        public void CollectInformation()
        {
            _dView.Render();
            string personalNumber = GetPersonalNumber();
            _memberOperations.RemoveUser(personalNumber);
        }

        public void DeleteBoat()
        {
            string personalNumber = GetPersonalNumber();
            _member = _memberOperations.GetUserInfo(personalNumber);
            _dView.PresentBoats(_member);
            int ID = _dView.GetBoatID();
            _memberOperations.RemoveBoat(_member, ID);
        }

        private string GetPersonalNumber() => _dView.GetUserPersonalNumber();
    }
}
