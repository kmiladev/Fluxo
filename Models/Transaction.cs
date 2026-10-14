
namespace Fluxo.Models
{
    // Essa classe é a representação de uma transação financeira dentro do sistema.
    //Responsabilidade: representar uma transação financeira.
    public class Transaction
    {
        // construtor
        public Transaction(string description, decimal amount, string type)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("The description cannot be empty.", nameof(description));
            }

            Description = description;

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The value must be greater than zero.");
            }

            Amount = amount;

            if (type != "Income" && type != "Expense")
            {
                throw new ArgumentException("The transaction type is invalid.", nameof(type));
            }

            Type = type;
        }

        // propriedades    
        public string Description { get; }
        public decimal Amount { get; }
        public string Type { get; }

    }
}