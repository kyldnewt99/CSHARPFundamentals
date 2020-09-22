using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI.Currency
{
    public class Transaction
    {
        private readonly ICurrency _currency;
        public DateTimeOffset DateOfTransaction { get; private set; }
        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }
        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }
        public string GetTransactionType() =>/*this is called a lambda. It's an expression, so it returns a value.*/ _currency.Name;
    }
}
