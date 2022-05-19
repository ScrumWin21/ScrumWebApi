using ScrumWin21WebAPI.BLL.Interfaces;
using ScrumWin21WebAPI.BLL.Models;
using ScrumWin21WebAPI.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.BLL.Services
{
    public class UserService : IUserService
    {
        public UserEntity ConvertToEntity(UserDisplayModel model)
        {
            throw new NotImplementedException();
        }

        public UserDisplayModel ConvertToModel(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<UserDisplayModel> ConvertToModelList(IEnumerable<UserEntity> entitiesList)
        {
            throw new NotImplementedException();
        }

        public bool ValidateEntity(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool ValidateModel(UserDisplayModel modelToConvert)
        {
            throw new NotImplementedException();
        }
    }
}
