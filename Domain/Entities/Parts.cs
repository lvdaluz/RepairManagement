using System.Collections.Generic;

namespace Domain.Entities
{
    public class Parts
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public decimal Value { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual IList<Budget> Budgets { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}