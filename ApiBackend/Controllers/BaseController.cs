using ApiBackend.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiBackend.Controllers
{
    public abstract class BaseController : Controller
    {

        public BaseController(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task<ActionResult<TResponse>> Execute<TRequest, TResponse>(TRequest request)
            where TRequest : IRequest<TResponse>
            where TResponse : BaseResponse, new()

        {
            var result = await Mediator.Send(request);
            return result;
        }

        public IMediator Mediator { get; }
    }
}