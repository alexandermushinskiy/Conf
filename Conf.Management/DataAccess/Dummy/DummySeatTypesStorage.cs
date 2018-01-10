using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.Entities;

namespace Conf.Management.DataAccess.Dummy
{
    public static class DummySeatTypesStorage
    {
        private static List<SeatType> storage;
        public static List<SeatType> Storage => storage ?? (storage = GetInitialData().ToList());

        private static IEnumerable<SeatType> GetInitialData()
        {
            return new[]
            {
                new SeatType
                {
                    Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1),
                    ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                    Name = "Preconference event",
                    Description = "Pre-conference workshop will offer an orientation on and general information to two intervention packages to support nurturing care: Care for Child Development (CCD) and the International Guide for Monitoring Child Development (GMCD). The workshop will inform participants of the potential of these tools, and also equip them with new insights and knowledge, thus being a professional development opportunity.",
                    Price = 255.5M,
                    Quantity = 50
                },
                new SeatType
                {
                    Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 2),
                    ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                    Name = "Full conference",
                    Description = "Once you've seen the innovative products on the show floor, let industry leaders and visionary speakers put the tech in context with CES conference programming.",
                    Price = 500M,
                    Quantity = 25
                },
                new SeatType
                {
                    Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 3),
                    ConferenceId = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                    Name = "Afterparty",
                    Description = "Is going to be a great space for people to come and connect with others from the conference. Most times you go to a conference but dont have time to mingle with all the amazing people.",
                    Price = 340M,
                    Quantity = 70
                },
                new SeatType
                {
                    Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 4),
                    ConferenceId = new Guid(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12),
                    Name = "General admission",
                    Description = "Join us as we prepare the California State University, San Bernardino campus to host its 6th Annual Pre-Medical & Pre-Health Conference!",
                    Price = 400M,
                    Quantity = 220
                },
                new SeatType
                {
                    Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 5),
                    Name = "Additional cocktail party",
                    Description = "Drinks, finger food and a chance to socialise with other delegates and friends.",
                    Price = 230M,
                    Quantity = 180
                },
                new SeatType
                {
                    Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 6),
                    ConferenceId = new Guid(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12),
                    Name = "Angular 5 Workshop",
                    Description = "Google's Angular family of frameworks are extremely productive for complex \"Single Page Apps\". Angular can be tough to learn, and you need to learn it well to obtain all its benefits. We can't make it easy, but we can teach you - and we focus on real, complex data-centric applications.",
                    Price = 400M,
                    Quantity = 240
                },
                new SeatType
                {
                    Id = new Guid(5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 7),
                    ConferenceId = new Guid(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13),
                    Name = "DDD Workshop",
                    Description = "The 3-day Workshop that rapidly unlocks the secrets to implementing DDD, both strategically and tactically. This Workshop is specially designed for mid-level and senior software developers and architects.",
                    Price = 380M,
                    Quantity = 170
                },
            };
        }
    }
}