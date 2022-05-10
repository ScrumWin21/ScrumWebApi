using ScrumWin21WebAPI.BLL.Interfaces;
using ScrumWin21WebAPI.BLL.Models;
using ScrumWin21WebAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.BLL
{
    public class BusinessLogicLayer
    {
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly DataAccessLayer _dal;
        public BusinessLogicLayer(IUserService userService, IProductService productService, IOrderService orderService, DataAccessLayer dal)
        {
            _userService = userService;
            _productService = productService;
            _orderService = orderService;
            _dal = dal;
        }

        #region Users
        public async Task<IEnumerable<UserDisplayModel>> GetUsersAsync() =>
            _userService.ConvertToModelList(await _dal.GetUsersAsync());

        public async Task<UserDisplayModel> GetUserByIdAsync(int id)
        {
            var userEntity = await _dal.GetUserByIdAsync(id);
            if (_userService.ValidateEntity(userEntity))
            {
                var userModel = _userService.ConvertToModel(userEntity);
                if(_userService.ValidateModel(userModel))
                    return userModel;
            }
            
            return new UserDisplayModel();
        }

        public async Task<UserDisplayModel> CreateUserAsync()
        {
            return new UserDisplayModel();
        }
        #endregion

        #region Products
        #endregion

        #region Orders
        #endregion

    }
}
