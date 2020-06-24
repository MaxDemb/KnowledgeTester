using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;

namespace DAL.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        //[Column(TypeName = "nvarchar(150)")]
        //public string FullName { get; set; }
        //public string Email { get; set; }
        //public string UserName { get; set; }
        //public int Year { get; set; }
    }
}
