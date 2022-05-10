using ScrumWin21WebAPI.BLL.Models;
using ScrumWin21WebAPI.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.BLL.Interfaces
{
    public interface IUserService
    {
        public bool ValidateModel(UserDisplayModel modelToConvert);
        public bool ValidateEntity(UserEntity convertedEntity);
        public UserEntity ConvertToEntity(UserDisplayModel model);
        public UserDisplayModel ConvertToModel(UserEntity entity);
        public List<UserDisplayModel> ConvertToModelList(IEnumerable<UserEntity> entitiesList);
    }
}
