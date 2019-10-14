using System;
using System.Threading;
using System.Threading.Tasks;
using ApiBackend.Models;
using ApiBackend.Requests;
using ApiBackend.Responses;
using MediatR;
namespace ApiBackend.Handlers
{
    public class UserHandler : HandlerBase, IRequestHandler<UserRequest, UserResponse>
    {
        public UserHandler()
        {
        }

        public async Task<UserResponse> Handle(UserRequest request, CancellationToken cancellationToken)
        {
            var response = new UserResponse();

            for (char @char = 'A'; @char < 'Z'; @char++)
            {
                response.UserList.Add(new User
                {
                    Email = @char + "@gmail.com",
                    UserName = @char.ToString(),
                    UserId = Guid.NewGuid().ToString()
                });
            }

            return await Task.FromResult(response);
        }
    }
    public abstract class HandlerBase
    {
    }
}
