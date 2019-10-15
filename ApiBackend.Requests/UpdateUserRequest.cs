using ApiBackend.Responses;
using MediatR;

namespace ApiBackend.Requests
{
    public class UpdateUserRequest : UserRequest, IRequest<UpdateUserResponse>
    {
         
    }
}
