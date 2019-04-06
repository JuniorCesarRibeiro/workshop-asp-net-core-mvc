using System;


namespace SalesWebMvc.Services.Exceptions
{
    public class IntregrityException : ApplicationException
    {
        public IntregrityException(string message) : base(message)
        {
        }
    }
}
