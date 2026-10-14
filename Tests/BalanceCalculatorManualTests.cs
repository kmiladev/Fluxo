using System;
using System.Collections.Generic;
using Fluxo.Models;
using Fluxo.Services;

public class BalanceCalculatorManualTests
{

    public void Run()
    {
        BalanceCalculator balanceCalculator = new BalanceCalculator();

        // Teste 1: lista vazia
        List<Transaction> emptyList = new List<Transaction>();
        decimal result1 = balanceCalculator.CalculateBalance(emptyList);
        if (result1 == 0M)
        {
            Console.WriteLine("Test 1 - Empty list: PASS");
        }
        else
        {
            Console.WriteLine($"Test 1 - Empty list: FAIL. Expected: 0, Actual: {result1}");
        }

        // Teste 2: somente receitas
        List<Transaction> incomes = new List<Transaction>
{
    new Transaction("Salary", 5000M, "Income"),
    new Transaction("Bonus", 1000M, "Income")
};
        decimal result2 = balanceCalculator.CalculateBalance(incomes);
        if (result2 == 6000M)
        {
            Console.WriteLine("Test 2 - Only incomes: PASS");
        }
        else
        {
            Console.WriteLine($"Test 2 - Only incomes: FAIL. Expected: 6000, Actual: {result2}");
        }

        // Teste 3: somente despesas
        List<Transaction> expenses = new List<Transaction>
{
    new Transaction("Rent", 1500M, "Expense"),
    new Transaction("Electricity", 300M, "Expense")
};
        decimal result3 = balanceCalculator.CalculateBalance(expenses);
       if (result3 == -1800M)
        {
            Console.WriteLine("Test 3 - Only expenses: PASS");
        }
        else
        {
            Console.WriteLine($"Test 3 - Only expenses: FAIL. Expected: -1800M, Actual: {result3}");
        }

        // Teste 4: receitas e despesas
        List<Transaction> mixed = new List<Transaction>
{
    new Transaction("Salary", 5000M, "Income"),
    new Transaction("Rent", 1500M, "Expense"),
    new Transaction("Bonus", 100M, "Income")
};
        decimal result4 = balanceCalculator.CalculateBalance(mixed);
        if (result4 == 3600M)
        {
            Console.WriteLine("Test 4 - mixed: PASS");
        }
        else
        {
            Console.WriteLine($"Test 4 - mixed: FAIL. Expected: 3600, Actual: {result4}");
        }

    }

}