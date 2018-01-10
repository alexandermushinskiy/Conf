using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.Entities;

namespace Conf.Management.DataAccess.Dummy
{
    internal static class DummyConferencesStorage
    {
        private static List<Conference> storage;
        public static List<Conference> Storage => storage ?? (storage = GetInitialData().ToList());

        private static IEnumerable<Conference> GetInitialData()
        {
            return new[]
            {
                new Conference
                {
                    Id = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                    AccessCode = "ASDFG",
                    Name = "RF-98th International Conference on Management, Economics & Social Science- ICMESS 2017",
                    Description = "Welcome to the Official Website of the 98th International Conference on Management, Economics & Social Science- ICMESS 2017. It will be held during 1st-2nd December, 2017 at Langkawi, Malaysia. ICMESS 2017 is being organized by Researchfora. The aim of the conference is to provide the platform for Students, Researchers and Academicians to share the knowledge and ideas in the recent trends in the field of Management, Economics & Social Science.",
                    StartDate = new DateTime(2018, 2, 1),
                    FinishDate = new DateTime(2018, 2, 8),
                    Organizer = new ConferenceOrganizer("Researchfora", "info@researchfora.com"),
                    Venue = "Langkawi, Malaysia"
                },
                new Conference
                {
                    Id = new Guid(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12),
                    AccessCode = "QWERT",
                    Name = "IASTEM - 286th International Conference on Economics and Business Management (ICEBM)",
                    Description = "IASTEM - 286th International Conference on Economics and Business Management (ICEBM) will be held on 1st-2nd December, 2017 at Kuala Lumpur , Malaysia. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    StartDate = new DateTime(2018, 2, 4),
                    FinishDate = new DateTime(2018, 2, 7),
                    Organizer = new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    Venue = "Kuala Lumpur, Malaysia"
                },
                new Conference
                {
                    Id = new Guid(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13),
                    AccessCode = "ZBMPF",
                    Name = "IASTEM - 287th International Conference on Economics and Business Management (ICEBM)",
                    Description = "IASTEM - 287th International Conference on Economics and Business Management (ICEBM) will be held on 3rd-4th December, 2017 at Oslo, Norway. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    StartDate = new DateTime(2018, 3, 12),
                    FinishDate = new DateTime(2018, 3, 14),
                    Organizer = new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    Venue = "Oslo, Norway"
                },
                new Conference
                {
                    Id = new Guid(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14),
                    AccessCode = "BVDXP",
                    Name = "RF-100th International Conference on Management, Economics & Social Science- ICMESS 2017",
                    Description = "Welcome to the Official Website of the 100th International Conference on Management, Economics & Social Science- ICMESS 2017. It will be held during 5th-6th December, 2017 at Perth, Australia. ICMESS 2017 is being organized by Researchfora. The aim of the conference is to provide the platform for Students, Researchers and Academicians to share the knowledge and ideas in the recent trends in the field of Management, Economics & Social Science.",
                    StartDate = new DateTime(2018, 2, 21),
                    FinishDate = new DateTime(2018, 2, 25),
                    Organizer = new ConferenceOrganizer("Researchfora", "info@researchfora.com"),
                    Venue = "Perth, Australia"
                },
                new Conference
                {
                    Id = new Guid(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15),
                    AccessCode = "FGHGF",
                    Name = "IASTEM - 289th International Conference on Economics and Business Management (ICEBM)",
                    Description = "IASTEM - 289th International Conference on Economics and Business Management (ICEBM) will be held on 6th-7th December, 2017 at Wellington, New Zealand. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    StartDate = new DateTime(2018, 3, 3),
                    FinishDate = new DateTime(2018, 3, 10),
                    Organizer = new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    Venue = "Wellington, New Zealand"
                },
                new Conference
                {
                    Id = new Guid(6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16),
                    AccessCode = "POIUY",
                    Name = "RF-101st International Conference on Management, Economics & Social Science- ICMESS 2017",
                    Description = "Welcome to the Official Website of the 101st International Conference on Management, Economics & Social Science- ICMESS 2017. It will be held during 8th-9th December, 2017 at Havana, Cuba. ICMESS 2017 is being organized by Researchfora. The aim of the conference is to provide the platform for Students, Researchers and Academicians to share the knowledge and ideas in the recent trends in the field of Management, Economics & Social Science.",
                    StartDate = new DateTime(2018, 2, 22),
                    FinishDate = new DateTime(2018, 2, 25),
                    Organizer = new ConferenceOrganizer("Researchfora", "info@researchfora.com"),
                    Venue = "Havana, Cuba"
                },
                new Conference
                {
                    Id = new Guid(7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17),
                    AccessCode = "JHGFD",
                    Name = "IASTEM - 295th International Conference on Economics and Business Management (ICEBM)",
                    Description = "IASTEM - 295th International Conference on Economics and Business Management (ICEBM) will be held on 17th-18th December, 2017 at Kiev, Ukraine. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    StartDate = new DateTime(2018, 4, 11),
                    FinishDate = new DateTime(2018, 4, 13),
                    Organizer = new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    Venue = "Kiev, Ukraine"
                },
                new Conference
                {
                    Id = new Guid(7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18),
                    AccessCode = "LINHD",
                    Name = "IASTEM - 290th International Conference on Economics and Business Management (ICEBM)",
                    Description = "IASTEM - 290th International Conference on Economics and Business Management (ICEBM) will be held on 9th-10th December, 2017 at Amsterdam, Netherlands. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    StartDate = new DateTime(2018, 4, 5),
                    FinishDate = new DateTime(2018, 4, 11),
                    Organizer = new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    Venue = "Amsterdam, Netherlands"
                },
            };
        }
    }
}