using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class CalculateInterest
    {
        //declaring class fields
        public double interest;
        public double principal;
        public double rate;
        public double period;
        public double amount;

        //Calculating simple interest method
        public void SimpleInterest()
        {
            interest = principal * rate / 100 * period / 12;
        }

        //Calculating simpleinterest amount method
        public void SimpleInterestAmount()
        {
            amount = principal + interest;
        }
    }
}
