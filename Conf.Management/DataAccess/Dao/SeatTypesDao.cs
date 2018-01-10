using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.DataAccess.Dummy;
using Conf.Management.Entities;
using Conf.Management.Extensibility.Dao;

namespace Conf.Management.DataAccess.Dao
{
    internal class SeatTypesDao : ISeatTypesDao
    {
        public IEnumerable<SeatType> GetConferenceSeatTypes(Guid conferenceId)
        {
            return DummySeatTypesStorage.Storage
                .Where(seatType => seatType.ConferenceId == conferenceId);
        }
    }
}