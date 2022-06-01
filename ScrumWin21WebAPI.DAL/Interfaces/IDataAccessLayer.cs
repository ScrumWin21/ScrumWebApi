using ScrumWin21WebAPI.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.DAL.Interfaces
{
    public interface IDataAccessLayer
    {
        #region Users

        Task<bool> CreateAsync(UserEntity newEntity);
        Task<IEnumerable<UserEntity>> GetAllAsync();

        #endregion
    }
}
