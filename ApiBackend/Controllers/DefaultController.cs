using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBackend.Requests;
using ApiBackend.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DefaultController : BaseController
    {
        public DefaultController(IMediator mediator) : base(mediator)
        {
        }

      
        public async Task<ActionResult<UserResponse>> GetUserDetails()
        {
            return await Execute<UserRequest, UserResponse>(new UserRequest());

        }
    }
}