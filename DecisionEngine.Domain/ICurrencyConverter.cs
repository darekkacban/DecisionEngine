using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public interface ICurrencyConverter
    {
        decimal ConvertToPLN(decimal amount);
    }
}
