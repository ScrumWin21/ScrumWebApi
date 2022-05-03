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
        Task<IEnumerable<UserEntity>> GetUsersAsync();
        Task GetUsersByIdAsync();
        Task CreateUserAsync();
        Task UpdateUserAsync();
        Task DeleteUserAsync();
    }
    public class DataAccessLayer : IDataAccessLayer
    {
        private readonly SqlContext _context;
        public DataAccessLayer(SqlContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserEntity>> GetUsersAsync() =>
            await _context.Users.ToListAsync();

        public Task GetUsersByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
