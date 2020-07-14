using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IStudentService studentService, ITeacherService teacherService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _studentService = studentService;
            _teacherService = teacherService;
        }

        [HttpPost]
        [Route("Register")]
        //api/user/register
        public async Task<ActionResult<UserModel>> PostUser(UserModel model)
        {
            if (model.Role == "Student")
            {
                var student = new StudentDTO
                {
                    Name = model.UserName,
                };
                await _studentService.AddStudent(student);
            }
            else if(model.Role == "Teacher")
            {

            }

            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email
            };



            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                await _userManager.AddToRoleAsync(applicationUser, model.Role);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            //[HttpPost]
            //[Route("Login")]
            //public async Task<ActionResult<UserModel>> LoginUser(UserModel model)
            //{
            //    var result = await _signInManager.PasswordSignInAsync(model.Email,
            //              model.Password, model.RememberMe, lockoutOnFailure: true);
            //}

            public ActionResult<string> Get()
            {
                return Ok("yes");
            }

        
    }
}