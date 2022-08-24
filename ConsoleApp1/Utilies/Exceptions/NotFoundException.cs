using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Utilies.Exceptions
{
    class NotFoundException: NotAvailableException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
