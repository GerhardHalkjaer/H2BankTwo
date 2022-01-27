using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo.Models
{
    class OverdraftException : Exception
    {
        public OverdraftException(string message)
        {
            throw new Exception(message);
        }




    }
}
