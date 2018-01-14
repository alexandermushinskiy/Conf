using System;
using System.Collections.Generic;
using AutoMapper;
using Conf.Infrastructure.Extensibility.Messaging;
using Conf.Management.Commands;
using Conf.Management.Extensibility.Dao;
using Microsoft.AspNetCore.Mvc;
using Conf.Management.Entities;
using Conf.Management.WebApi.Models.Responses;
using Conf.Management.WebApi.Models.Requests;

namespace Conf.Management.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/conferences/{conferenceId:guid}/seattypes")]
    public class SeatTypesController : Controller
    {
        private readonly ICommandHandler<CreateSeatTypeCommand> createSeatTypeCommandHandler;
        private readonly ISeatTypesDao seatTypesDao;
        private readonly IMapper mapper;

        public SeatTypesController(
            ICommandHandler<CreateSeatTypeCommand> createSeatTypeCommandHandler,
            ISeatTypesDao seatTypesDao,
            IMapper mapper)
        {
            this.createSeatTypeCommandHandler = createSeatTypeCommandHandler;
            this.seatTypesDao = seatTypesDao;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get(Guid conferenceId)
        {
            IEnumerable<SeatType> seatTypes = seatTypesDao.GetConferenceSeatTypes(conferenceId);
            return Ok(seatTypes);
        }

        [HttpPost]
        public IActionResult Post(Guid conferenceId, [FromBody]CreateSeatTypeRequestModel createSeatTypeRequestModel)
        {
            CreateSeatTypeCommand command = mapper.Map<CreateSeatTypeRequestModel, CreateSeatTypeCommand>(createSeatTypeRequestModel);
            command.ConferenceId = conferenceId;
            createSeatTypeCommandHandler.Handle(command);

            CreateSeatTypeResponseModel response = new CreateSeatTypeResponseModel { Id = command.Id }; ;
            return Created($"api/conferences/{conferenceId}/seattypes/{command.Id}", response);
        }
    }
}