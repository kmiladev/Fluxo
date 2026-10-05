
using Fluxo.Models;

Transaction transaction = new Transaction();

string description = "Salary";
decimal amount = 5000M;
string type = "Income";

transaction.Description = description;
transaction.Amount = amount;
transaction.Type = type;

Console.WriteLine($"Description {transaction.Description}");
Console.WriteLine($"Amount {transaction.Amount}");
Console.WriteLine($"Type {transaction.Type}");  

Transaction transaction2 = new Transaction();

string description2 = "Rent";
decimal amount2 = 1500M;
string type2 = "Expense";

transaction2.Description = description2;
transaction2.Amount = amount2;
transaction2.Type = type2;

Console.WriteLine($"Description {transaction2.Description}");
Console.WriteLine($"Amount {transaction2.Amount}");
Console.WriteLine($"Type {transaction2.Type}"); 

Console.WriteLine($"------- LISTA DE TRANSAÇOES -------"); 

// List<Transaction> é uma lista que pode guardar vários objetos Transaction
// List<tipo = classe/objeto> variávelDeArmazenamento = objeto instanciado.

 decimal balance = 0M;

List<Transaction> transactions = new List<Transaction>();

transactions.Add(transaction);
transactions.Add(transaction2);
try{
    foreach(Transaction itemTransaction in transactions)
    {
        if(itemTransaction.Type == "Income")
    {
        balance = balance + itemTransaction.Amount;
    }
    else if (itemTransaction.Type == "Expense")
    {
        balance = balance - itemTransaction.Amount;
    }
    else
    {
        throw new ArgumentException("O tipo da transação é inválido");
    }
    
        Console.WriteLine($"Transaction: {itemTransaction.Description}");
        Console.WriteLine($"Amount: {itemTransaction.Amount}");
        Console.WriteLine($"Type: {itemTransaction.Type}");
    }
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
    //income -> dinheiro entrando(soma) / expense -> dinheiro saindo(subtrai).

Console.WriteLine($"The Current Balance is: {balance}");
   