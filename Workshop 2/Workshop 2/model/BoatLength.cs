using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.model
{
    class BoatLength
    {
        private string _length;

        public BoatLength(string length)
        {
            Length = length;
        }
        public string Length
        {
            get { return _length; }
            set
            {
                int len;
                if (!int.TryParse(value, out len))
                {
                    throw new Exception("No letters in length.");
                }

                if (len <= 0 || len > 100)
                {
                    throw new Exception("Invalid length. 1 - 100 length.");
                }

                _length = value;
            }
        }
    }
}
