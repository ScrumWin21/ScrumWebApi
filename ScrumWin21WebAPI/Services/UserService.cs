using ScrumWin21WebAPI.DAL.Data.Entities;
using ScrumWin21WebAPI.DAL;
using ScrumWin21WebAPI.Models;

namespace ScrumWin21WebAPI.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserCreateModel>> GetUsersAsync();
    }
    public class UserService : IUserService
    {
        private readonly IDataAccessLayer _dataAccessLayer;
        public UserService(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }

        public async Task<IEnumerable<UserCreateModel>> GetUsersAsync()
        {
            var userModelList = new List<UserCreateModel>();
            var userEntityList = await _dataAccessLayer.GetUsersAsync();

            foreach (var userEntity in userEntityList)
            {
                UserCreateModel userModel = new UserCreateModel
                {
                    FirstName = userEntity.FirstName,
                    LastName = userEntity.LastName,
                    Email = userEntity.Email,
                };
                userModelList.Add(userModel);
            }
            return userModelList;
        }
    }
}
