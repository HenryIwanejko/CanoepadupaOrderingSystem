using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Exceptions
{
    public class DatabaseException : Exception
    {
        readonly string _Message;

        public DatabaseException(string message) : base(message)
        {
            _Message = "Database Error: " + message;
        }

        public override string Message
        {
            get { return _Message; }
        }
    }
}
