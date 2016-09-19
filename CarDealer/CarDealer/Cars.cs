using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Cars
    {
        public string Brand { get; set; }
        public string Modell { get; set; }
        public string hp { get; set; }
        public string passangers { get; set; }
        public string year { get; set; }
        public bool busy { get; set; }
        public string customer { get; set; }
        public override string ToString()
        {
            return string.Format("{0} is rented by {1}",Brand,customer);
        }

    }
}
