using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.Entities;

namespace Conf.Management.DataAccess.Dummy
{
    internal static class DummyOrdersStorage
    {
        private static List<Order> storage;
        public static List<Order> Storage => storage ?? (storage = GetInitialData().ToList());

        private static IEnumerable<Order> GetInitialData()
        {
            return new[]
            {
                new Order
                {
                    Id = new Guid(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2),
                    ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                    AccessCode = "ORD12",
                    RegistrantName = "Peter Pen",
                    RegistrantEmail = "peter.pen@mail.ua",
                    TotalAmount = 2,
                    Status = OrderStatus.Paid,
                    Seats = new List<OrderSeat>
                    {
                        new OrderSeat
                        {
                            OrderId = new Guid(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2),
                            Attendee = new Attendee("peter.pen@mail.ua", "Peter", "Pen"),
                            Position = 1,
                            SeatInfo = new SeatType
                            {
                                Id = new Guid(2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1),
                                Name = "General",
                                Description = "general description",
                                Price = 12.5M,
                                Quantity = 1
                            }
                        },
                        new OrderSeat
                        {
                            OrderId = new Guid(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2),
                            Attendee = new Attendee("luke.skywalker@mail.ua", "Luke", "Skywalker"),
                            Position = 2,
                            SeatInfo = new SeatType
                            {
                                Id = new Guid(2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1),
                                Name = "General",
                                Description = "general description",
                                Price = 12.5M,
                                Quantity = 1
                            }
                        }
                    }
                },
                new Order
                {
                    Id = new Guid(1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3),
                    ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                    AccessCode = "GAF11",
                    RegistrantName = "Will Smith",
                    RegistrantEmail = "will.sm@mail.ua",
                    TotalAmount = 1,
                    Status = OrderStatus.Paid,
                    Seats = new List<OrderSeat>
                    {
                        new OrderSeat
                        {
                            OrderId = new Guid(1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3),
                            Attendee = new Attendee("kate.blanshet@mail.ua", "Kate", "Blanshet"),
                            Position = 12,
                            SeatInfo = new SeatType
                            {
                                Id = new Guid(2, 2, 2, 2, 2, 2, 2, 2, 1, 3, 3),
                                Name = "General",
                                Description = "general description",
                                Price = 12.5M,
                                Quantity = 1
                            }
                        }
                    }
                }
            };
        }
    }
}