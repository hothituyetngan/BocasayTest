using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bocasay.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public abstract class BaseController : Controller
    {
        protected readonly IMediator _mediator;

        protected BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
