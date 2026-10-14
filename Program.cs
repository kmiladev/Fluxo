
using Fluxo.Models;
using Fluxo.Services;

Console.WriteLine($"------- LIST OF TRANSACTIONS -------");

// List<Transaction> é uma lista que pode guardar vários objetos Transaction
// List<tipo = classe/objeto> variávelDeArmazenamento = objeto instanciado.


TransactionService transactionService = new TransactionService();

transactionService.AddTransaction(new Transaction ("Salary", 5000M, "Income"));
transactionService.AddTransaction(new Transaction ("Rent", 1500M, "Expense"));
transactionService.AddTransaction(new Transaction ("Electricity Bill", 300M, "Expense"));
transactionService.AddTransaction(new Transaction ("Lawyer", 500M, "Expense"));
transactionService.AddTransaction(new Transaction ("Freelancer", 100M, "Income"));

List<Transaction> currentTransactions = transactionService.GetTransactions();

BalanceCalculator balanceCalculator = new BalanceCalculator();
decimal currentBalance = balanceCalculator.CalculateBalance(currentTransactions);

foreach (Transaction itemTransaction in currentTransactions)
{
    Console.WriteLine($"Transaction: {itemTransaction.Description}");
    Console.WriteLine($"Amount: {itemTransaction.Amount:C2}");
    Console.WriteLine($"Type: {itemTransaction.Type}");
}

Console.WriteLine($"------- LIST OF TEST -------");

BalanceCalculatorManualTests tests = new BalanceCalculatorManualTests();
tests.Run();


Console.WriteLine($"The Current Balance is: {currentBalance:C2}");
