using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Conf.Management.Entities;
using Conf.Management.Extensibility.Dao;

namespace Conf.Management.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/conferences/{conferenceId:guid}/orders")]
    public class OrdersController : Controller
    {
        private readonly IOrderDao orderDao;

        public OrdersController(IOrderDao orderDao)
        {
            this.orderDao = orderDao;
        }

        [HttpGet]
        public IActionResult Get(Guid conferenceId)
        {
            IEnumerable<Order> orders = orderDao.GetConferenceOrders(conferenceId);
            return Ok(orders);
        }
    }
}