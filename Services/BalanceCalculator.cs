using System.Collections.Generic;
using Fluxo.Models;

namespace Fluxo.Services
{
    // Responsabilidade: calcular o saldo a partir de uma coleção de transações.
    public class BalanceCalculator
    {
        public decimal CalculateBalance(List<Transaction> transactions)
        {
            decimal balance = 0M;

            foreach (Transaction itemTransaction in transactions)
            {
                if (itemTransaction.Type == "Income")
                {
                    balance += itemTransaction.Amount;
                }
                else if (itemTransaction.Type == "Expense")
                {
                    balance -= itemTransaction.Amount;
                }

            }
            return balance;
        }
    }
}

//income -> dinheiro entrando(soma) / expense -> dinheiro saindo(subtrai).