using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using DAL.Domain.Entities;
using BLL.Infrastructure.Services;
using BLL.Interfaces;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        public UserProfileController(UserManager<ApplicationUser> userManager, ITeacherService teacherService, IStudentService studentService)
        {
            _userManager = userManager;
            _teacherService = teacherService;
            _studentService = studentService;
        }

        [HttpGet]
        [Authorize]
        //GET : /api/UserProfile
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.Email,
                user.UserName
            };
        }

        [HttpGet]
        [Authorize(Roles = "Teacher")]
        [Route("ForTeacher")]
        public async Task<TeacherModel> GetForTeacher()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);

            int teacherId = await _teacherService.GetTeacherIdByUserIdAsync(userId); 

            return new TeacherModel
            {
                Id = teacherId, 
                Email = user.Email,
                UserName = user.UserName
            };
        }

        [HttpGet]
        [Authorize(Roles = "Student")]
        [Route("ForStudent")]
        public async Task<ActionResult<StudentModel>> GetStudent()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);

            int studentId = await _studentService.GetStudentdByUserIdAsync(userId);

            return new StudentModel
            {
                Id = studentId,
                Email = user.Email,
                UserName = user.UserName
            };
        }

        [HttpGet]
        [Authorize(Roles = "Teacher,Student")]
        [Route("ForAll")]
        public string GetForStudentOrTeacher()
        {
            return "Web method for Student or Teacher";
        }
    }
}