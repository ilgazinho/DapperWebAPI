using System;
using System.Collections.Generic;
using System.Linq;
using DapperWebAPI.Models;
using DapperWebAPI.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}


/*


public UserController()
{

}

[HttpPost("authenticate")]
public IActionResult Authenticate(AuthenticateRequest model)
{
    var response = _userService.Authenticate(model);

    if (response == null)
        return BadRequest(new { message = "Username or password is incorrect" });

    return Ok(response);
}

// GET api/v1/products/{id}
/// <summary>
/// Get Product
/// </summary>
/// <param name="id"></param>
/// <returns>return product</returns>
[HttpGet("{id}")]
public User Get(long id)
{
    List<User> list = new List<User>();
    list.Add(new User()
    {
        Id = 1,
        Username = "sa",
        FirstName="Admin",
        LastName="Yönetici",
        Password="1"
    }
    );
    list.Add(new User()
    {
        Id = 2,
        Username = "user",
        FirstName="User",
        LastName="Kullanıcı",
        Password="123456"
    }
  );
    return list.Where(x => x.Id == id).FirstOrDefault();
    //   return await _productBusiness.GetAsync(id);
}
}
}
 */