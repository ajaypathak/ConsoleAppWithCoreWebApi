using ApiBackend.Responses;
using MediatR;
using System;

namespace ApiBackend.Requests
{
    public class UserRequest:BaseRequest,IRequest<UserResponse>
    {
        public string UserName { get; set; }
    }
}
