using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Blackbird.Domain.Enumerations;

namespace Blackbird.Domain.Entities
{
    public class Purchase : Entity<Guid>
    {
        public Guid CustomerId { get; set; }

        [NotMapped]
        public List<Guid> ProductIds { get; set; } = new List<Guid>();

        public DateTime Created { get; set; } = DateTime.Now;

        public PaymentType PaymentType { get; set; }

        public Purchase(Guid customerId, PaymentType payment) : base(Guid.NewGuid())
        {
            CustomerId = customerId;
            PaymentType = payment;
        }
    }
}
