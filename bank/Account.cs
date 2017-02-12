using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemtentaTdd2017.bank
{
    public class Account : IAccount
    {
        public double Balance { get; set; }


        public void Deposit(double amount)
        {
            if (IsLegal(amount))
            {
                Balance += amount;
            }
            else
            {
                throw new AccountExceptions.IllegalAmountException("Amount: " + amount + " is illegal");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public bool IsLegal(double value)
        {
         const double max_transfer_value = 10000;
         const double min_transfer_value = 10;
            if (value > max_transfer_value)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void Transfer(IAccount destination, double amount)
        {
            if ((destination) != null)
            {
                if (!IsLegal(amount))
                {
                    Console.WriteLine(amount);
                    destination.Deposit(amount);
                }
            } 

        }

        public double ClearAll()
        {
            Balance = 0.0;
            return Balance;
        }

       
        
    }
}
