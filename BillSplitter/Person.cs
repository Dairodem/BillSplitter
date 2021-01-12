using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    class Person
    {
        public string Name { get; set; }
        public List<double> Bills { get; set; }

        public Person()
        {
            Bills = new List<double>();
        }

    }
}
