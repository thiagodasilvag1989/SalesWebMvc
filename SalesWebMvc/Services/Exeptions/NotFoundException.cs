using System;

namespace SalesWebMvc.Services.Exeptions
{
    public class NotFoundException : AccessViolationException
    {
        public NotFoundException (string message) : base(message)
        {

        }
    }
}
