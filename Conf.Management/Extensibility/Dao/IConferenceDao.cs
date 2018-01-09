using System;
using Conf.Management.Dao.Models;

namespace Conf.Management.Extensibility.Dao
{
    public interface IConferenceDao
    {
        ConferenceDetails Locate(string ownerEmail, string accessCode);
        ConferenceDetails GetConferenceDetails(Guid conferenceId);
    }
}