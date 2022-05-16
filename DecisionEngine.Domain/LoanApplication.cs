using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class LoanApplication
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Customer Customer { get; set; }

        public Decision Decision { get; set; }
        public decimal Amount { get; set; }

        public LoanApplication(Customer customer)
        {
            Customer = customer;
        }

        public Decision GetDecision()
        {
            return Decision;
        }

    }
}
