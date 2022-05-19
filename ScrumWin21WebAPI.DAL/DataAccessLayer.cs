using Microsoft.EntityFrameworkCore;
using ScrumWin21WebAPI.DAL.Data;
using ScrumWin21WebAPI.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.DAL
{
    public interface IDataAccessLayer
    {
        #region Users

        #endregion
    }
    public class DataAccessLayer : IDataAccessLayer
    {
        private readonly SqlContext _context;
        public DataAccessLayer(SqlContext context)
        {
            _context = context;
        }

        #region Users

        #endregion
    }
}
