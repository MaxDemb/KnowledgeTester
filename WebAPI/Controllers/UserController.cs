using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       
            private UserManager<ApplicationUser> _userManager;
            private SignInManager<ApplicationUser> _singInManager;

            public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
            {
                _userManager = userManager;
                _singInManager = signInManager;
            }

            [HttpPost]
            [Route("Register")]
            //api/user/register
            public async Task<Object> PostUser(UserModel model)
            {
                var applicationUser = new ApplicationUser()
                {
                    UserName = model.UserName,
                    Email = model.Email
                };

                try
                {
                    var result = await _userManager.CreateAsync(applicationUser, model.Password);
                    return Ok(result);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }


            public ActionResult<string> Get()
            {
                return Ok("yes");
            }

        
    }
}