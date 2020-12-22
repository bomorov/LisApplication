using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
