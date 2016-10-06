using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
