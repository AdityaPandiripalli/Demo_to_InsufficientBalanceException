using System;

namespace Demo_to_InsufficientBalanceException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(1000m);

            try
            {
                account.Withdraw(1500m); // Attempt to withdraw more than the balance
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
                // Optionally, display attempted withdrawal if available
                if (ex is InsufficientBalanceException customEx && customEx.AttemptedWithdrawal > 0)
                {
                    Console.WriteLine($"Attempted withdrawal: {customEx.AttemptedWithdrawal}");
                }
            }
        }
    }
}
