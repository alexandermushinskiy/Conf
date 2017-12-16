using Conf.Management.Dao.Models;

namespace Conf.Management.Extensibility.Dao
{
    public interface IConferenceDao
    {
        ConferenceDetails GetConferenceDetails(string conferenceCode);
    }
}