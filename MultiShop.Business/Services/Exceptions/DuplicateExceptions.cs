using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services.Exceptions
{
    public class DuplicateExceptions : Exception
    {
        public DuplicateExceptions(string? message) : base(message)
        {
        }
    }
}
