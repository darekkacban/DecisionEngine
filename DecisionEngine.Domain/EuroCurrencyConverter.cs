using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class EuroCurrencyConverter : ICurrencyConverter
    {
        public decimal ConvertToPLN(decimal amount)
        {
            return amount * 4.8m;
        }
    }
}
