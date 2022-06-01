﻿using ScrumWin21WebAPI.BLL.Models;
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
        public bool ValidateModel(UserModel modelToConvert);
        public (bool, UserEntity) ValidateEntity(UserEntity entity);
        public UserEntity ConvertToEntity(UserModel model);
        public UserModel ConvertToModel(UserEntity entity);
        public List<UserModel> ConvertToModelList(IEnumerable<UserEntity> entitiesList);
    }
}
