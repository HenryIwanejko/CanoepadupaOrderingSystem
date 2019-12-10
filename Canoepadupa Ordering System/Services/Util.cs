using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanoepadupaOrderingSystem.Exceptions;

namespace CanoepadupaOrderingSystem.Services
{
    public class Util
    {
        public static string GetExceptionMessage(Exception ex)
        {
            if (ex is DatabaseException)
            {
                return ex.Message;
            }
            else
            {
                return "Error Occured";
            }
        }
    }
}
