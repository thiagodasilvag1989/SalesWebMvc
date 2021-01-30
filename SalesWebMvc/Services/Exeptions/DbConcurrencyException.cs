using System;


namespace SalesWebMvc.Services.Exeptions
{
    public class DbConcurrencyException : AccessViolationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
