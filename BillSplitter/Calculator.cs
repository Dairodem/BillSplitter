using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    public class Calculator
    {
        public string OutputText { get; set; }

        private int    count = 0;
        private double mainTotal = 0;
        private double amountToPay = 0;

        public Calculator(List<Person> personList)
        {
            // Get total payed by all participants
            foreach (Person person in personList)
            {
                count++;
                mainTotal += person.Total;
            }

            // gets the amount to pay by an individual
            amountToPay = mainTotal / count;

            // gets the difference between amount to pay and already payed
            foreach (Person person in personList)
            {
                person.Difference = amountToPay - person.Total;
            }

            // finds out who has to pay who
            foreach (Person person1 in personList)
            {
                double transfer = 0;

                // searches the first person who payed too much
                if (person1.Difference < 0)
                {
                    foreach (Person person2 in personList)
                    {
                        if (person1.Name != person2.Name && person2.Difference > 0)
                        {
                            double diff = person1.Difference + person2.Difference;

                            if (diff < 0)
                            {
                                transfer = Math.Abs(person2.Difference);
                                person1.Difference = diff;
                                person2.Difference = 0;
                            }
                            else if (diff > 0)
                            {
                                transfer = Math.Abs(person1.Difference);
                                person2.Difference = diff;
                                person1.Difference = 0;
                            }
                            else
                            {
                                transfer = Math.Abs(person2.Difference);
                                person1.Difference = diff;
                                person2.Difference = diff;
                            }

                            OutputText += $"{person1.Name} krijgt {Math.Round(transfer,2)} van {person2.Name}.\n";

                        }


                    }
                }
            }

        }

    }
}
