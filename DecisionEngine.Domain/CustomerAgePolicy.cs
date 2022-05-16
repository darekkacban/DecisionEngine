using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class CustomerAgePolicy : IPolicy
    {
        public bool GetDecision(LoanApplication application)
        {
            var age = DateTime.UtcNow.Year - application.Customer.BirthDate.Year;

            return age >= 18;
        }
    }
}
