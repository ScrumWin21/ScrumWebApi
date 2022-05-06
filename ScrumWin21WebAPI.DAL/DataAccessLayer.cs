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
        Task<IEnumerable<UserEntity>> GetUsersAsync();
        Task<UserEntity> GetUserByIdAsync();
        Task<UserEntity> CreateUserAsync();
        Task<UserEntity> UpdateUserAsync();
        Task<bool> DeleteUserAsync();
        #endregion

        #region Products
        Task<ProductEntity> GetProductsAsync();
        Task<ProductEntity> GetProductByIdAsync();
        Task<ProductEntity> CreateProductAsync();
        Task<ProductEntity> UpdateProductAsync();
        Task<bool> DeleteProductAsync();
        #endregion

        #region Orders
        Task<OrderEntity> GetOrdersAsync();
        Task<OrderEntity> GetOrderByIdAsync();
        Task<OrderEntity> CreateOrderAsync();
        Task<OrderEntity> UpdateOrderAsync();
        Task<bool> DeleteOrderAsync();
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
        public async Task<IEnumerable<UserEntity>> GetUsersAsync() =>
            await _context.Users.ToListAsync();

        public Task<UserEntity> GetUserByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> CreateUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> UpdateUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Products
        public Task<ProductEntity> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> GetProductByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> CreateProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> UpdateProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Orders
        public Task<OrderEntity> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderEntity> GetOrderByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderEntity> CreateOrderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderEntity> UpdateOrderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOrderAsync()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
