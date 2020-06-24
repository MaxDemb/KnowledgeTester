using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class SignedInUserDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
        public SignedInUserDTO(UserDTO user, string token)
        {
            User = user;
            Token = token;
        }
    }
}
