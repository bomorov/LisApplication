using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MediatR.Districts.Commands;
using Application.MediatR.Districts.Queries;

namespace WebUI.Controllers
{
    public class DistrictController : BaseController
    {
        public async Task<IActionResult> Index(GetDistrictsQuery query)
        {
            var districts = await Mediator.Send(query);
            return Ok(districts);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDistrictCommand command)
        {
            var (result, id) = await Mediator.Send(command);
            if (!result.Succeeded)
                return BadRequest(result.Messages);
            return Ok(command);
        }
    }
}
