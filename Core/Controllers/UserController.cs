using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Core.Models;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;
        private readonly ApplicationSettings _appSettings;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IStudentService studentService, ITeacherService teacherService,
            IOptions<ApplicationSettings> appSettings)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _studentService = studentService;
            _teacherService = teacherService;
            _appSettings = appSettings.Value;
        }

        [HttpPost]
        [Route("Register")]
        //api/user/register
        public async Task<ActionResult<UserModel>> PostUser(UserModel model)
        {

            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email
            };


            var result = await _userManager.CreateAsync(applicationUser, model.Password);
            await _userManager.AddToRoleAsync(applicationUser, model.Role);

            var user = await _userManager.FindByNameAsync(model.UserName);


            if (model.Role == "Student")
            {
                var student = new StudentDTO
                {
                    Name = model.UserName,
                    UserId = user.Id
                };
                await _studentService.AddStudent(student);

            }
            else if (model.Role == "Teacher")
            {

                var teacher = new TeacherDTO
                {
                    Name = model.UserName,
                    UserId = user.Id
                };
                await _teacherService.AddTeacher(teacher);
            }
            return Ok(result);
       
        }

        //[HttpPost]
        //[Route("Login")]

        ////api/user/login
        //public async Task<ActionResult<Microsoft.AspNetCore.Identity.SignInResult>> LoginUser(UserModel model)
        //{
        //    var result = await _signInManager.PasswordSignInAsync(model.UserName,
        //              model.Password, true, lockoutOnFailure: true);
        //    return result;
        //}

        [HttpPost]
        [Route("Login")]
        //POST : /api/ApplicationUser/Login
        public async Task<IActionResult> Login(UserModel model)
        {

            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {


                //Get role assigned to the user
                var role = await _userManager.GetRolesAsync(user);
                 IdentityOptions _options = new IdentityOptions();

                var tokenDescriptor = new SecurityTokenDescriptor
                {

                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Id.ToString()),
                         new Claim(_options.ClaimsIdentity.RoleClaimType,role.FirstOrDefault())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
        }



    }
}