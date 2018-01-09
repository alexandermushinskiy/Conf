using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.Dao.Models;
using Conf.Management.Entities;
using Conf.Management.Extensibility.Dao;
using Conf.Management.DataAccess.Dummy;

namespace Conf.Management.DataAccess.Dao
{
    internal class ConferenceDao : IConferenceDao
    {
        public ConferenceDetails Locate(string ownerEmail, string conferenceCode)
        {
            return DummyConferencesStorage.Storage
                .Where(conf => conf.Organizer.Email == ownerEmail && conf.AccessCode == conferenceCode)
                .Select(ConvertToDaoModel)
                .FirstOrDefault();
        }

        public ConferenceDetails GetConferenceDetails(Guid conferenceId)
        {
            return DummyConferencesStorage.Storage
                .Where(c => c.Id == conferenceId)
                .Select(ConvertToDaoModel)
                .FirstOrDefault();
        }

        private static ConferenceDetails ConvertToDaoModel(Conference conference)
        {
            if (conference == null)
            {
                return null;
            }

            return new ConferenceDetails(
                conference.Id,
                conference.AccessCode,
                conference.Name,
                conference.Description,
                conference.Venue,
                conference.StartDate,
                conference.FinishDate);
        }
    }
}