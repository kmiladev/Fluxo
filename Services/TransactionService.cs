using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fluxo.Models;

namespace Fluxo.Services
//gerencia o cadastro e a consulta das transações.

{
    public class TransactionService // Instância do serviço que gerencia as transações.
    {
        private readonly List<Transaction> transactions = new List<Transaction>();


        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction); // ADICIONANDO ITEM INDIVIDUAL transaction a lista transactions
        }

        public List<Transaction> GetTransactions()
        {            
            return transactions; // devolvendo a lista inteira
        }
    }
}

// Transaction = É a classe, o molde que define como é uma transação: descrição, valor e tipo. (MOLDE)

//  transaction = É uma transação individual, um objeto recebido por um método, por exemplo, pelo AddTransaction. (ITEM)

// transactions = É uma lista que guarda várias transações. (LISTA DE ITENS)

//Salário = R$ 5.000,00 · Income
//Aluguel = R$ 1.500,00 · Expense

/*
List<Transaction>
O tipo da variável: uma lista que pode armazenar objetos Transaction.

transactions
O nome que você escolheu para acessar essa lista.

=
Atribui à variável a referência à lista criada.

new List<Transaction>()
Cria uma nova lista vazia.

Portanto, essa linha cria uma lista vazia e permite acessá-la pelo nome transactions.
*/
