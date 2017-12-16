using System;
using System.Collections.Generic;
using Conf.Management.Entities;

namespace Conf.Management.Infrastructure.DataAccess.Dummy
{
    internal static class DummyStorage
    {
        public static IEnumerable<Conference> GetData()
        {
            return new Conference[]
            {
                new Conference(
                    new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11),
                    "ASDFG",
                    "RF-98th International Conference on Management, Economics & Social Science- ICMESS 2017",
                    "Welcome to the Official Website of the 98th International Conference on Management, Economics & Social Science- ICMESS 2017. It will be held during 1st-2nd December, 2017 at Langkawi, Malaysia. ICMESS 2017 is being organized by Researchfora. The aim of the conference is to provide the platform for Students, Researchers and Academicians to share the knowledge and ideas in the recent trends in the field of Management, Economics & Social Science.",
                    new DateTime(2018, 2, 1),
                    new DateTime(2018, 2, 8),
                    new ConferenceOrganizer("Researchfora", "info@researchfora.com"),
                    "Langkawi, Malaysia"),
                new Conference(
                    new Guid(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12),
                    "QWERT",
                    "IASTEM - 286th International Conference on Economics and Business Management (ICEBM)",
                    "IASTEM - 286th International Conference on Economics and Business Management (ICEBM) will be held on 1st-2nd December, 2017 at Kuala Lumpur , Malaysia. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    new DateTime(2018, 2, 4),
                    new DateTime(2018, 2, 7),
                    new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    "Kuala Lumpur, Malaysia"),
                new Conference(
                    new Guid(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13),
                    "ZBMPF",
                    "IASTEM - 287th International Conference on Economics and Business Management (ICEBM)",
                    "IASTEM - 287th International Conference on Economics and Business Management (ICEBM) will be held on 3rd-4th December, 2017 at Oslo, Norway. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    new DateTime(2018, 3, 12),
                    new DateTime(2018, 3, 14),
                    new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    "Oslo, Norway"),
                new Conference(
                    new Guid(4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14),
                    "BVDXP",
                    "RF-100th International Conference on Management, Economics & Social Science- ICMESS 2017",
                    "Welcome to the Official Website of the 100th International Conference on Management, Economics & Social Science- ICMESS 2017. It will be held during 5th-6th December, 2017 at Perth, Australia. ICMESS 2017 is being organized by Researchfora. The aim of the conference is to provide the platform for Students, Researchers and Academicians to share the knowledge and ideas in the recent trends in the field of Management, Economics & Social Science.",
                    new DateTime(2018, 2, 21),
                    new DateTime(2018, 2, 25),
                    new ConferenceOrganizer("Researchfora", "info@researchfora.com"),
                    "Perth, Australia"),
                new Conference(
                    new Guid(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15),
                    "FGHGF",
                    "IASTEM - 289th International Conference on Economics and Business Management (ICEBM)",
                    "IASTEM - 289th International Conference on Economics and Business Management (ICEBM) will be held on 6th-7th December, 2017 at Wellington, New Zealand. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    new DateTime(2018, 3, 3),
                    new DateTime(2018, 3, 10),
                    new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    "Wellington, New Zealand"),
                new Conference(
                    new Guid(6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16),
                    "POIUY",
                    "RF-101st International Conference on Management, Economics & Social Science- ICMESS 2017",
                    "Welcome to the Official Website of the 101st International Conference on Management, Economics & Social Science- ICMESS 2017. It will be held during 8th-9th December, 2017 at Havana, Cuba. ICMESS 2017 is being organized by Researchfora. The aim of the conference is to provide the platform for Students, Researchers and Academicians to share the knowledge and ideas in the recent trends in the field of Management, Economics & Social Science.",
                    new DateTime(2018, 2, 22),
                    new DateTime(2018, 2, 25),
                    new ConferenceOrganizer("Researchfora", "info@researchfora.com"),
                    "Havana, Cuba"),
                new Conference(
                    new Guid(7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17),
                    "JHGFD",
                    "IASTEM - 295th International Conference on Economics and Business Management (ICEBM)",
                    "IASTEM - 295th International Conference on Economics and Business Management (ICEBM) will be held on 17th-18th December, 2017 at Kiev, Ukraine. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    new DateTime(2018, 4, 11),
                    new DateTime(2018, 4, 13),
                    new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    "Kiev, Ukraine"),
                new Conference(
                    new Guid(7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18),
                    "LINHD",
                    "IASTEM - 290th International Conference on Economics and Business Management (ICEBM)",
                    "IASTEM - 290th International Conference on Economics and Business Management (ICEBM) will be held on 9th-10th December, 2017 at Amsterdam, Netherlands. ICEBM is to bring together innovative academics and industrial experts in the field of Economics and Business Management to a common forum.",
                    new DateTime(2018, 4, 5),
                    new DateTime(2018, 4, 11),
                    new ConferenceOrganizer("IASTEM", "info@iastem.org"),
                    "Amsterdam, Netherlands")
            };
        }
    }
}