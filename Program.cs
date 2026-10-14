
using Fluxo.Models;
using Fluxo.Services;

Transaction transaction = new Transaction("Salary", 5000M, "Income");
Transaction transaction2 = new Transaction("Rent", 1500M, "Expense");
Transaction transaction3 = new Transaction("Electricity Bill", 300M, "Expense");
Transaction transaction4 = new Transaction("Lawyer", 500M, "Expense");
Transaction transaction5 = new Transaction("Freelancer", 100, "Income");

Console.WriteLine($"------- LIST OF TRANSACTIONS -------");

// List<Transaction> é uma lista que pode guardar vários objetos Transaction
// List<tipo = classe/objeto> variávelDeArmazenamento = objeto instanciado.

List<Transaction> transactions = new List<Transaction>();

transactions.Add(transaction);
transactions.Add(transaction2);
transactions.Add(transaction3);
transactions.Add(transaction4);
transactions.Add(transaction5);

BalanceCalculator balanceCalculator = new BalanceCalculator();
decimal returnBalanceCalculator = balanceCalculator.CalculateBalance(transactions);

foreach (Transaction itemTransaction in transactions)
{
    Console.WriteLine($"Transaction: {itemTransaction.Description}");
    Console.WriteLine($"Amount: {itemTransaction.Amount:C2}");
    Console.WriteLine($"Type: {itemTransaction.Type}");
}


Console.WriteLine($"------- LIST OF TEST -------");

BalanceCalculatorManualTests tests = new BalanceCalculatorManualTests();
tests.Run();


Console.WriteLine($"The Current Balance is: {returnBalanceCalculator:C2}");
