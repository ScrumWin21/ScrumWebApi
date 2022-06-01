using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.BLL.Models
{
    public class UserModel
    {
        public UserModel()
        {
        }

        public UserModel(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }

        public UserModel(string userName, string email, string password)
        {
            UserName = userName;
            Email = email;
            Password = password;
        }

        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
