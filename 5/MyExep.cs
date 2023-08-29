using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class OurException : Exception
    {
        public OurException(string? message) : base(message)
        {

        }
    }
}
