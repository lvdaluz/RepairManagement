using System;

namespace Domain.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public DateTimeOffset BudgetDeliveryDeadline { get; set; }
        public DateTimeOffset? BudgetDelivered { get; set; }
        public bool? Authorized { get; set; }
        public bool Finalized { get; set; }
        public string Product { get; set; }
        public string? Description { get; set; }
        public Decimal? TotalValue { get; set; }
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int CreatedBy { get; set; }
        public virtual Technician TechnicianWhoCreated { get; set; }
        public int? RepairBy { get; set; }
        public virtual Technician TechnicianWhoRepair { get; set; }

        public bool IsValid() =>
            !string.IsNullOrWhiteSpace(Product)
            && ProductTypeId > 0
            && ClientId > 0
            && CreatedBy > 0;
    }
}