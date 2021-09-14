using System;
using System.Collections.Generic;
using DapperWebAPI.Models;

namespace DapperWebAPI.Service
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
