using System;
using System.Collections.Generic;
using Conf.Management.Entities;

namespace Conf.Management.Extensibility.Dao
{
    public interface ISeatTypesDao
    {
        IEnumerable<SeatType> GetConferenceSeatTypes(Guid conferenceId);
    }
}