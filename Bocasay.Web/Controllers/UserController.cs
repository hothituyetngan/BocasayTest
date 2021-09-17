using Bocasay.Web.Models.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bocasay.Web.Controllers
{
    public class UserController : BaseController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreatePostRequest request)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(request.User);
                TempData["Msg"] = "Your full name is created successfully";
            }

            return RedirectToAction("Create");
        }
    }
}
