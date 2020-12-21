using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MediatR.Regions.Queries;
using Domain.Entities;
using MediatR;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("regions")]
    public class RegionController:Controller
    {
        private readonly IMediator _mediator;

        public RegionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<List<Region>> Index(GetRegionsQuery query)
        {
            return _mediator.Send(query);
        }
    }

}
