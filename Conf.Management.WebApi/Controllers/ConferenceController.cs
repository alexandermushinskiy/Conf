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
    [Produces("application/json")]
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

        [HttpGet]
        public IEnumerable<Conference> Get()
        {
            return conferenceRepository.GetAll();
        }

        [HttpGet("details")]
        public IActionResult GetConferenceDetails(string conferenceCode)
        {
            ConferenceDetails conferenceDetails = conferenceDao.GetConferenceDetails(conferenceCode);
            if (conferenceDetails == null)
            {
                return NotFound($"Conference with code {conferenceCode} is not found");
            }
            return Ok(conferenceDetails);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody]CreateRequestModel createRequestModel)
        {
            CreateConferenceCommand command = mapper.Map<CreateConferenceCommand>(createRequestModel);  
            createConferenceCommandHandler.Handle(command);

            CreateResponseModel response = new CreateResponseModel { Id = command.Id };
            return Created($"api/details/{command.AccessCode}", response);
        }
    }
}