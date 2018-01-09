using System;
using System.Collections.Generic;
using Conf.Management.Entities;
using Conf.Management.Extensibility.Repositories;
using Conf.Management.DataAccess.Dummy;

namespace Conf.Management.DataAccess.Repositories
{
    internal class ConferenceRepository : IConferenceRepository
    {
        public IEnumerable<Conference> GetAll()
        {
            return DummyConferencesStorage.Storage;
        }
        
        public Conference GetById(Guid id)
        {
            return DummyConferencesStorage.Storage.Find(conf => conf.Id == id);
        }

        public void Create(Conference conference)
        {
            DummyConferencesStorage.Storage.Add(conference);
        }

        public void Update(Conference conference)
        {
            int index = DummyConferencesStorage.Storage.FindIndex(conf => conf.Id == conference.Id);
            DummyConferencesStorage.Storage[index] = conference;
        }

        public void Delete(Conference conference)
        {
            DummyConferencesStorage.Storage.Remove(conference);
        }
    }
}