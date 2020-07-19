//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using DAL.Domain.Entities;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//namespace Core.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserProfileController : ControllerBase
//    {
//        private UserManager<ApplicationUser> _userManager;
//        public UserProfileController(UserManager<ApplicationUser> userManager)
//        {
//            _userManager = userManager;
//        }

//        [HttpGet]
//        [Authorize]
//        //GET : /api/UserProfile
//        public async Task<Object> GetUserProfile()
//        {

//            string userId = User.Claims.First(c => c.Type == "UserID").Value;
//            var user = await _userManager.FindByIdAsync(userId);
//            return new
//            {
//                //user.FullName,
//                user.Email,
//                user.UserName
//            };
//        }


//        [HttpGet]
//        [Authorize(Roles = "Student")]
//        [Route("ForStudent")]
//        public string GetForStudent()
//        {
//            return "Web method for Student";
//        }

//        [HttpGet]
//        [Authorize(Roles = "Teacher")]
//        [Route("~/api/UserProfile/ForTeacher")]
//        public string GetForTeacher()
//        {
//            return "Web method for Teacher";
//        }

//        [HttpGet]
//        [Authorize(Roles = "Student,Teacher")]
//        [Route("ForStudentOrTeacher")]
//        public string GetForStudentOrTeacher()
//        {
//            return "Web method for Student or Teacher";
//        }
//    }
//}
