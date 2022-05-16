using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
        public string NIP { get; set; }
        public bool IsBankCustomer { get; set; }
        public decimal MonthNetIncome { get; set; }
        public int FamilyMembers { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
