using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Exceptions
{
    public class ContaNaoLogadaException : Exception
    {
        public ContaNaoLogadaException(string msg) : base(msg)
        {

        }
    }
}
