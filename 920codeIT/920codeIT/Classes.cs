using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _920codeIT
{
    public class People
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phoneNbr { get; set; }
    }

    public class Customers : People
    {
        public string customerID { get; set; }
    }

    public class Employees : People
    {
        public string employeeID { get; set; }
        public string title { get; set; }
        public string pay { get; set; }
    }
    public class Supplier : People
    {
        public string company { get; set; }
    }
}
