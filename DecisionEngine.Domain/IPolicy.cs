using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public interface IPolicy
    {
        bool GetDecision(LoanApplication application);
    }
}
