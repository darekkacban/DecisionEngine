using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class BankCustomerPolicy : IPolicy
    {
        public bool GetDecision(LoanApplication application)
        {
            return application.Customer.IsBankCustomer;
        }
    }
}
