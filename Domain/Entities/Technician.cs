using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Technician
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public virtual People People { get; set; }
        public DateTimeOffset HiredIn { get; set; }
        public DateTimeOffset? FiredIn { get; set; }
        public virtual IList<Budget> Budgets { get; set; }
        public virtual IList<Budget> Repairs { get; set; }

        public bool IsValid() =>
            PeopleId != 0
            && HiredIn != null;
    }
}