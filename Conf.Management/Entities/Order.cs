using System;
using System.Collections.Generic;

namespace Conf.Management.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid ConferenceId { get; set; }

        public string AccessCode { get; set; }

        public string RegistrantName { get; set; }

        public string RegistrantEmail { get; set; }

        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; }

        public ICollection<OrderSeat> Seats { get; set; }
    }
}