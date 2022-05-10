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
            return new UserEntity()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };
        }

        public UserDisplayModel ConvertToModel(UserEntity entity)
        {
            return new UserDisplayModel()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email
            };
        }

        public List<UserDisplayModel> ConvertToModelList(IEnumerable<UserEntity> entitiesList)
        {
            List<UserDisplayModel> modelList = new List<UserDisplayModel>();
            foreach (var entity in entitiesList)
                modelList.Add(ConvertToModel(entity));

            return modelList;
        }

        public bool ValidateEntity(UserEntity entity)
        {
            if(entity == null)
                return false;
            else
                return true;
        }

        public bool ValidateModel(UserDisplayModel modelToConvert)
        {
            if (modelToConvert == null)
                return false;
            else
                return true;
        }
    }
}
