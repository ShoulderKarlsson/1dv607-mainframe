using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.model
{
    public class MemberName
    {
        private string _name;
        public MemberName(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Name is too short!");
                }

                if (value.Length > 100)
                {
                    throw new Exception("Name is too long!");
                }

                _name = value;
            }
        }
    }
}
