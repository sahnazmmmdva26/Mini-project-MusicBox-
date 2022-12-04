using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBox
{
    internal class WrongCommandException : Exception
    {
        public WrongCommandException (string message) : base(message)
        {

        }
    }
}
