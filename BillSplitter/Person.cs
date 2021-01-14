using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    public class Person
    {
        public string Name { get; set; }
        public List<double> Bills { get; set; }
        public double Total { get; set; }

        public Person()
        {
            Bills = new List<double>();
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
