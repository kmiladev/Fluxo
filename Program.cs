
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
// Teste 1: lista vazia
List<Transaction> emptyList = new List<Transaction>();
decimal result1 = balanceCalculator.CalculateBalance(emptyList);
Console.WriteLine($"Test 1 - Empty list: {result1}");

// Teste 2: somente receitas
List<Transaction> incomes = new List<Transaction>
{
    new Transaction("Salary", 5000M, "Income"),
    new Transaction("Bonus", 1000M, "Income")
};
decimal result2 = balanceCalculator.CalculateBalance(incomes);
Console.WriteLine($"Test 2 - Only incomes: {result2}");

// Teste 3: somente despesas
List<Transaction> expenses = new List<Transaction>
{
    new Transaction("Rent", 1500M, "Expense"),
    new Transaction("Electricity", 300M, "Expense")
};
decimal result3 = balanceCalculator.CalculateBalance(expenses);
Console.WriteLine($"Test 3 - Only expenses: {result3}");

// Teste 4: receitas e despesas
List<Transaction> mixed = new List<Transaction>
{
    new Transaction("Salary", 5000M, "Income"),
    new Transaction("Rent", 1500M, "Expense"),
    new Transaction("Bonus", 100M, "Income")
};
decimal result4 = balanceCalculator.CalculateBalance(mixed);
Console.WriteLine($"Test 4 - Mixed: {result4}");



Console.WriteLine($"The Current Balance is: {returnBalanceCalculator:C2}");
