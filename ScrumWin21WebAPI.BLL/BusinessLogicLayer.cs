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
        
            
        #endregion

    }
}
