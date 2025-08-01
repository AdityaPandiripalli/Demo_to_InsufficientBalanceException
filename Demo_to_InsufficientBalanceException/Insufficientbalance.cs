using System;

namespace Demo_to_InsufficientBalanceException
{
    // Custom input exception for insufficient balance
    internal class InsufficientBalanceException : Exception
    {
        // Step 2: Constructor that takes a message parameter
        public InsufficientBalanceException(string message) : base(message)
        {
        }

        // Step 3: Optionally, add additional properties or methods if needed
        // For demonstration, let's add a property for the attempted withdrawal amount
        public decimal AttemptedWithdrawal { get; }

        public InsufficientBalanceException(string message, decimal attemptedWithdrawal) : base(message)
        {
            AttemptedWithdrawal = attemptedWithdrawal;
        }
    }

    // Step 4: Create a class with BankAccount and a method to withdraw money
    internal class BankAccount
    {
        // Balance property with getter and private setter
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                // Throw custom exception if insufficient balance
                throw new InsufficientBalanceException("Insufficient balance for withdrawal.", amount);
            }
            Balance -= amount;
        }
    }
}
