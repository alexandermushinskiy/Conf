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
                    TotalAmount = 3,
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
                                Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1),
                                ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                                Name = "Preconference event",
                                Description = "Pre-conference workshop will offer an orientation on and general information to two intervention packages to support nurturing care: Care for Child Development (CCD) and the International Guide for Monitoring Child Development (GMCD). The workshop will inform participants of the potential of these tools, and also equip them with new insights and knowledge, thus being a professional development opportunity.",
                                Price = 255.5M,
                                Quantity = 50
                            }
                        },
                        new OrderSeat
                        {
                            OrderId = new Guid(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2),
                            Attendee = new Attendee("peter.pen@mail.ua", "Peter", "Pen"),
                            Position = 5,
                            SeatInfo = new SeatType
                            {
                                Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 2),
                                ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                                Name = "Full conference",
                                Description = "Once you've seen the innovative products on the show floor, let industry leaders and visionary speakers put the tech in context with CES conference programming.",
                                Price = 500M,
                                Quantity = 25
                            }
                        },
                        new OrderSeat
                        {
                            OrderId = new Guid(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2),
                            Attendee = new Attendee("luke.skywalker@mail.ua", "Luke", "Skywalker"),
                            Position = 2,
                            SeatInfo = new SeatType
                            {
                                Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 2),
                                ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                                Name = "Full conference",
                                Description = "Once you've seen the innovative products on the show floor, let industry leaders and visionary speakers put the tech in context with CES conference programming.",
                                Price = 500M,
                                Quantity = 25
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
                                Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 2),
                                ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                                Name = "Full conference",
                                Description = "Once you've seen the innovative products on the show floor, let industry leaders and visionary speakers put the tech in context with CES conference programming.",
                                Price = 500M,
                                Quantity = 25
                            }
                        }
                    }
                }
            };
        }
    }
}