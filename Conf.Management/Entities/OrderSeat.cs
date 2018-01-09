using System;

namespace Conf.Management.Entities
{
    public class OrderSeat
    {
        public Guid OrderId { get; set; }

        public Attendee Attendee { get; set; }

        public int Position { get; set; }

        public SeatType SeatInfo { get; set; }
    }
}