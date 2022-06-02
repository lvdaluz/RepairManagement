using System.Collections.Generic;

namespace Domain.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public virtual IList<Parts> Parts { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}