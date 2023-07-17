using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public Transaction(DateTime date, string type, decimal amount)
        {
            Date = date;
            Type = type;
            Amount = amount;
        }
    }
}
