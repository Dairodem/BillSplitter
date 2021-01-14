using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    public class Calculator
    {
        private int count = 0;
        private double mainTotal = 0;
        private double amountToPay = 0;
        private double diff = 0;

        public Calculator(List<Person> personList)
        {
            foreach (Person person in personList)
            {
                count++;
                mainTotal += person.Total;
            }

            amountToPay = mainTotal / count;

            foreach (Person person in personList)
            {
                diff = amountToPay - person.Total;
            }

        }

    }
}
