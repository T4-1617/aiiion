using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winformklass
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string id { get; set; }
        public string Fullname()
        {
            return string.Format("{0} {1}", Firstname, Lastname);
        }
    }
}
