using System;
using System.Collections.Generic;
using Conf.Management.Entities;

namespace Conf.Management.Extensibility.Dao
{
    public interface IOrderDao
    {
        IEnumerable<Order> GetConferenceOrders(Guid conferenceId);
        Order GetOrder(Guid orderId);
    }
}