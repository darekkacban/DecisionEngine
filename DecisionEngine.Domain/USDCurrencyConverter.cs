using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class USDCurrencyConverter : ICurrencyConverter
    {
        public decimal ConvertToPLN(decimal amount)
        {
            return amount * 4.5m;
        }
    }
}
