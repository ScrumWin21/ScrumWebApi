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
        public UserEntity ConvertToEntity(UserModel model)
        {
            var newEntity = new UserEntity
            {
                Username = model.Username,
                Email = model.Email,
            };
            newEntity.EncryptPassword(model.Password);

            return newEntity;
        }

        public UserModel ConvertToModel(UserEntity entity)
        {
            var newModel = new UserModel
            {
                Username = entity.Username,
                Email = entity.Email,
                Password = "-Unknown-"
            };

            return newModel;
        }

        public List<UserModel> ConvertToModelList(IEnumerable<UserEntity> entitiesList)
        {
            throw new NotImplementedException();
        }

        public (bool, UserEntity) ValidateEntity(UserEntity entity)
        {

            if(string.IsNullOrEmpty(entity.Username) || string.IsNullOrEmpty(entity.Email) || entity.Security == null || entity.SecurityLayer == null)
                return (false, entity);
            
            else return (true, entity);
        }

        public bool ValidateModel(UserModel model)
        {
            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
                return false;

            else 
                return true;
        }
    }
}
