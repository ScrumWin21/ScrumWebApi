using ScrumWin21WebAPI.BLL.Models;
using ScrumWin21WebAPI.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.BLL.Services
{
    public class UserService
    {
        public bool ValidUser(UserDisplayModel model)
        {
            if (model == null)
                return false;
            else return true;
        }
        public UserEntity ConvertToEntity(UserDisplayModel model)
        {
            UserEntity userEntity = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
            };
            return userEntity;
        }
        public bool ValidConversion(UserEntity entity)
        {
            if (entity == null)
                return false;
            else return true;
        }
    }
}
