using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Exceptions
{
    public class AdminServiceException : Exception
    {
        public AdminServiceException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}
