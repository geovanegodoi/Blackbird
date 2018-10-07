using System;
using System.Collections.Generic;
using Blackbird.Domain.Enumerations;

namespace Blackbird.Domain.Entities
{
    public class Purchase : Entity<Guid>
    {
        public Guid CustomerId { get; set; }

        public IEnumerable<Guid> ProductIds { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public PaymentType PaymentType { get; set; }

        public Purchase(Guid customerId, IEnumerable<Guid> productIds, PaymentType paymentType)
            : base(Guid.NewGuid())
        {
            CustomerId = customerId;
            ProductIds = productIds;
            PaymentType = paymentType;
        }
    }
}
