using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MediatR.Districts.Commands;
using Application.MediatR.Districts.Queries;
using Newtonsoft.Json;

namespace WebUI.Controllers
{
    public class DistrictController : BaseController
    {
        public async Task<IActionResult> Index(GetDistrictsQuery query)
        {
            var districts = await Mediator.Send(query);
            return Ok(districts);
        }


        //public IActionResult Create() => View();

        //[HttpPost]
        //public async Task<ActionResult<int>> Create(CreateDistrictCommand command)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(command);
        //    }

        //    var (result, id) = await Mediator.Send(command);
        //    TempData["AlertResult"] = JsonConvert.SerializeObject(result);

        //    if (!result.Succeeded)
        //    {
        //        ModelState.AddModelError(string.Empty, result.Messages.ToString());
        //        return View(command);
        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        [HttpPost]
        public async Task<IActionResult> Create(CreateDistrictCommand command)
        {
            var (result, id) = await Mediator.Send(command);
            if (!result.Succeeded)
                return BadRequest(result.Messages);
            return Ok();
        }
    }
}
