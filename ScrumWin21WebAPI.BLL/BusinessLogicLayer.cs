using ScrumWin21WebAPI.BLL.Models;
using ScrumWin21WebAPI.BLL.Services;
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
        private readonly UserService _userService;
        private readonly DataAccessLayer _dll;
        public BusinessLogicLayer(UserService userService, DataAccessLayer dll)
        {
            _userService = userService;
            _dll = dll;
        }

        #region Users
        public async Task<UserDisplayModel> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Products
        #endregion

        #region Orders
        #endregion

    }
}
