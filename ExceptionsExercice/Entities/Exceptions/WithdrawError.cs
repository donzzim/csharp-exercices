using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExercicio.Entities.Exceptions
{
    internal class WithdrawError : ArgumentException
    {
        public WithdrawError(string message) : base(message) 
        { 

        }
    }
}
