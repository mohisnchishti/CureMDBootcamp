using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    public interface ITransaction
    {
        void ExecuteTransaction(double amount);
        void PrintTransaction();
    }
}
