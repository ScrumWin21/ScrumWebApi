using ScrumWin21WebAPI.DAL.Data.Entities;
using ScrumWin21WebAPI.DAL;
using ScrumWin21WebAPI.Models.DisplayModels;

namespace ScrumWin21WebAPI.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDisplayModel>> GetUsersAsync();
        Task<UserDisplayModel> GetUserByIdAsync(int id);
    }
    public class UserService : IUserService
    {
        private readonly IDataAccessLayer _dataAccessLayer;
        public UserService(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }

        public async Task<IEnumerable<UserDisplayModel>> GetUsersAsync()
        {
            var userModelList = new List<UserDisplayModel>();
            var userEntityList = await _dataAccessLayer.GetUsersAsync();

            foreach (var userEntity in userEntityList)
            {
                UserDisplayModel userModel = new UserDisplayModel
                {
                    FirstName = userEntity.FirstName,
                    LastName = userEntity.LastName,
                    Email = userEntity.Email,
                };
                userModelList.Add(userModel);
            }
            return userModelList;
        }

        public async Task<UserDisplayModel> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
