using System.Collections.Generic;

namespace Domain.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual IList<Budget> Budgets { get; set; }

        public bool IsValid() =>
            Description != null;
    }
}