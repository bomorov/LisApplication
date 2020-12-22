using Application.MediatR.Regions.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class RegionController : BaseController
    {
        public async Task<IActionResult> Index(GetRegionsQuery query)
        {
            ViewData["Regions"] = await Mediator.Send(query);
            return View(query);
        }
    }
}