using System;
using System.Collections.Generic;
using System.Linq;
using Conf.Management.DataAccess.Dummy;
using Conf.Management.Entities;
using Conf.Management.Extensibility.Dao;

namespace Conf.Management.DataAccess.Dao
{
    internal class OrderDao : IOrderDao
    {
        public IEnumerable<Order> GetConferenceOrders(Guid conferenceId)
        {
            return DummyOrdersStorage.Storage
                .Where(order => order.ConferenceId == conferenceId);
        }

        public Order GetOrder(Guid orderId)
        {
            return DummyOrdersStorage.Storage
                .FirstOrDefault(order => order.Id == orderId);
        }
    }
}