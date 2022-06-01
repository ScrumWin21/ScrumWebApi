using ScrumWin21WebAPI.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.BLL.Interfaces
{
    public interface IBusinessLogicLayer
    {
        #region Users

        Task<(string, UserModel)> CreateAsync(UserModel newUserModel);

        #endregion
    }
}
