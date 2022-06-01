using Microsoft.EntityFrameworkCore;
using ScrumWin21WebAPI.DAL.Data;
using ScrumWin21WebAPI.DAL.Data.Entities;
using ScrumWin21WebAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.DAL
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private readonly SqlContext _context;
        public DataAccessLayer(SqlContext context)
        {
            _context = context;
        }

        #region Users
        public async Task<bool> CreateAsync(UserEntity newEntity)
        {
            var addedEntity = await _context.AddAsync(newEntity);
            var success = await _context.SaveChangesAsync();
            if (success > 0 && addedEntity != null)
                return true;

            else return false;
        }
        #endregion
    }
}
