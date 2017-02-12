using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.bank
{
    public interface IAccount
    {
        // Account balance
        double Balance { get; }

        // Deposit funds
        void Deposit(double amount);

        // Withdraw funds
        void Withdraw(double amount);

        // Transfer funds from account to another
        void Transfer(IAccount destination, double amount);

        // Clear all, reset account to zero 0.
        double ClearAll();
    }
}
