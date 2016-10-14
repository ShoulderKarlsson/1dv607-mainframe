using Workshop_2.model;
using Workshop_2.view;


namespace Workshop_2.controller
{
    class RegisterController : BaseController
    {
        private readonly RegisterView _rView;

        public RegisterController()
        {
            _rView = new RegisterView(_memberOperations);
        }

        public void CollectInformation()
        {
            _rView.Render();
            string mN = _rView.GetName();
            string personalNumber = _rView.GetUserPersonalNumber(true);
            int memberId = _memberOperations.GenerateID();

            Member newMember = new Member(mN, personalNumber, memberId);
            SaveMember(newMember);
        }

        public void CollectNewBoatInformation()
        {
            string personalNumber = _rView.GetUserPersonalNumber();
            string boatLength = _rView.GetBoatLength();
            string bt = _rView.GetBoatType();

            Boat newBoat = new Boat(bt, boatLength);
            _memberOperations.SaveBoat(newBoat, personalNumber);
        }


        private void SaveMember(Member member)
        {
            _memberOperations.AddUser(member);
        }
    }
}
