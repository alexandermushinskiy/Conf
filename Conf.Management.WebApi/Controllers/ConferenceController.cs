using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Conf.Management.Extensibility.Repositories;
using Conf.Management.Entities;
using Conf.Management.WebApi.Models.Responses;
using Conf.Management.WebApi.Models.Requests;
using Conf.Management.Commands;
using Conf.Management.Extensibility.Dao;
using Conf.Management.Dao.Models;
using Conf.Infrastructure.Extensibility.Messaging;

namespace Conf.Management.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ConferencesController : Controller
    {
        private readonly ICommandHandler<CreateConferenceCommand> createConferenceCommandHandler;
        private readonly IConferenceDao conferenceDao;
        private readonly IConferenceRepository conferenceRepository;
        private readonly IMapper mapper;

        public ConferencesController(
            IMapper mapper,
            ICommandHandler<CreateConferenceCommand> createConferenceCommandHandler,
            IConferenceDao conferenceDao,
            IConferenceRepository conferenceRepository)
        {
            this.createConferenceCommandHandler = createConferenceCommandHandler;
            this.conferenceDao = conferenceDao;
            this.mapper = mapper;

            this.conferenceRepository = conferenceRepository;
        }

        [HttpPost("locate")]
        public IActionResult Locate([FromBody]LocateRequestModel locateRequestModel)
        {
            ConferenceDetails conferenceDetails = conferenceDao.Locate(locateRequestModel.Email, locateRequestModel.AccessCode);
            if (conferenceDetails == null)
            {
                return NotFound("Conference is not found");
            }
            return Ok(conferenceDetails);
        }

        [HttpGet("all")]
        public IEnumerable<Conference> Get()
        {
            return conferenceRepository.GetAll();
        }

        [HttpGet("{conferenceId:guid}")]
        public IActionResult GetConferenceDetails(Guid conferenceId)
        {
            ConferenceDetails conferenceDetails = conferenceDao.GetConferenceDetails(conferenceId);
            if (conferenceDetails == null)
            {
                return NotFound($"Conference with id {conferenceId} is not found");
            }
            return Ok(conferenceDetails);
        }

        [HttpPost]
        public IActionResult Post([FromBody]CreateRequestModel createRequestModel)
        {
            CreateConferenceCommand command = mapper.Map<CreateConferenceCommand>(createRequestModel);  
            createConferenceCommandHandler.Handle(command);

            CreateResponseModel response = new CreateResponseModel { Id = command.Id };
            return Created($"api/details/{command.Id}", response);
        }       
    }
}