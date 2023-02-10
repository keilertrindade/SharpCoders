using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Exceptions
{
    public class ContaInativaException : ContaException
    {
        public ContaInativaException(string msg)
            :base(msg) { }
    }
}
