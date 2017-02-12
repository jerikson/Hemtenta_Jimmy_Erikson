using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.bank
{
    public class AccountExceptions
    {
        // Throw exception when amount of account does not allow the withdraw or other explanation
        public class InsufficientFundsException : Exception { }

        // Throw for illegal values
        public class IllegalAmountException : Exception
        {
            public IllegalAmountException(string message) : base(message)
            {
            }
        }

        // Kastas om en operation på kontot inte tillåts av någon
        // anledning som inte de andra exceptions täcker in
        public class OperationNotPermittedException : Exception { }
    }
}
