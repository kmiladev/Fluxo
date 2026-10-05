using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluxo.Models
{
    // Essa classe é a representação de uma transação financeira dentro do sistema.
    public class Transaction
    
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
    public string Type { get; set; }
    }
}