using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class BankTransaction
    {
        public readonly DateTime date_time;
        public readonly decimal sum;

        public BankTransaction(decimal sum)
        {
            this.sum = sum;
            date_time = DateTime.Now;
        }
    }
}
