using ApiBackend.Requests;
using ApiBackend.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiBackend.Handlers
{
    public class UpdateUserHandler : HandlerBase, IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {
        public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new UpdateUserResponse());
        }
    }
}
