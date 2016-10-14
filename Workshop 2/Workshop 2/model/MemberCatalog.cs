using System.Collections.Generic;

namespace Workshop_2.model
{
    class MemberCatalog
    {
        public List<Member> _storedMembers;

        public MemberCatalog(Database db)
        {
            _storedMembers = db.GetMemberList();
        }
    }
}
