using System;

namespace Vns.Core.Commons
{
    public class VnsException : Exception
    {
        public VnsException(string message): base(message) { }
    }
}
