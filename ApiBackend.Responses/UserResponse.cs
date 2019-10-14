using ApiBackend.Models;
using System;
using System.Collections.Generic;

namespace ApiBackend.Responses
{
    public class UserResponse:BaseResponse
    {
        public List<User> UserList { get; set; }
        public UserResponse()
        {
            UserList = new List<User>();
        }
    }
}
