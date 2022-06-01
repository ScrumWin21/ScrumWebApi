using ScrumWin21WebAPI.BLL.Interfaces;
using ScrumWin21WebAPI.BLL.Models;
using ScrumWin21WebAPI.DAL;
using ScrumWin21WebAPI.DAL.Data.Entities;
using ScrumWin21WebAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.BLL
{
    public class BusinessLogicLayer : IBusinessLogicLayer
    {
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IDataAccessLayer _dal;
        public BusinessLogicLayer(IUserService userService, IProductService productService, IOrderService orderService, IDataAccessLayer dal)
        {
            _userService = userService;
            _productService = productService;
            _orderService = orderService;
            _dal = dal;
        }

        #region Users
        public async Task<(string, UserModel)> CreateAsync(UserModel newUserModel)
        {
            var entityList = await _dal.GetAllAsync();
            foreach(var entity in entityList)
            {
                if (entity.Username == newUserModel.Username)
                    return ("That username is already taken.", newUserModel);

                else if (entity.Email == newUserModel.Email)
                    return ("That email is already taken.", newUserModel);
            }

            var success = _userService.ValidateEntity(_userService.ConvertToEntity(newUserModel));

            if (success.Item1 == true)
            {
                var savedEntity = await _dal.CreateAsync(success.Item2);
                var savedModel = _userService.ConvertToModel(success.Item2);
                if (savedEntity == true)
                    return ("", savedModel);
                else
                    return ("Could not save to database.", savedModel);
            }
            else
                return ("The input was not correct.", newUserModel);
        }

        #endregion

    }
}
