using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Exceptions
{
    public class SaldoInsufficientException : ContaException
    {
        public SaldoInsufficientException(string msg):base(msg) { }
    }
}
