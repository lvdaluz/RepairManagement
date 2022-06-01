using System.Collections.Generic;

namespace Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string BillingAddress { get; set; }
        public int PeopleId { get; set; }
        public virtual People People { get; set; }
        public virtual IList<Budget> Budgets { get; set; }

        public bool IsValid() =>
            BillingAddress?.Length > 3
            && PeopleId != 0;
    }
}