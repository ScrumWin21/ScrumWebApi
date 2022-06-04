using ScrumWin21WebAPI.BLL.Interfaces;
using ScrumWin21WebAPI.BLL.Models;
using ScrumWin21WebAPI.BLL.Services;
using ScrumWin21WebAPI.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ScrumWin21WebAPI.Tests
{
    public class UserServiceTests : IClassFixture<UserService>
    {
        private readonly UserService _userService;

        public UserServiceTests(UserService userservice)
        {
            _userService = userservice;
        }

        [Fact]
        public void ConvertToEntity_ShouldModelToEntity()
        {
            //Arrange
            UserModel testModel = new() { Username = "Aleks", Email = "aleks@domain.com", Password = "BytMig123!" };
            UserEntity expected = new() { Username = "Aleks", Email = "aleks@domain.com" };

            //Act
            var actual = _userService.ConvertToEntity(testModel);

            //Assert
            Assert.NotNull(actual);
            Assert.IsType<UserEntity>(actual);
            Assert.Equal((expected.Username), (actual.Username));
            Assert.Equal(expected.Email, actual.Email);
            Assert.True(actual.Security != null && actual.SecurityLayer != null);
        }

        [Fact]
        public void ConvertToModel_ShouldEntityToModel()
        {
            //Arrange
            UserEntity testEntity = new() { Username = "Aleks", Email = "aleks@domain.com" };
            UserModel expected = new() { Username = "Aleks", Email = "aleks@domain.com", Password = "-Unknown-" };

            //Act
            var actual = _userService.ConvertToModel(testEntity);

            //Assert
            Assert.NotNull(actual);
            Assert.IsType<UserModel>(actual);
            Assert.Equal(expected.Username, actual.Username);
            Assert.Equal(expected.Email, actual.Email);
        }

        [Fact]
        public void ValidateEntity_ShouldValidate()
        {
            //Arrange
            UserEntity testNotValid = new();
            UserEntity testValid = new() { Username = "Aleks", Email = "aleks@domain.com" };
            testValid.EncryptPassword("BytMig123!");

            //Act
            var actualNotValid = _userService.ValidateEntity(testNotValid);
            var actualValid = _userService.ValidateEntity(testValid);

            //Assert
            Assert.False(actualNotValid.Item1);
            Assert.IsType<UserEntity>(actualNotValid.Item2);

            Assert.True(actualValid.Item1);
            Assert.IsType<UserEntity>(actualValid.Item2);
        }

        [Fact]
        public void ValidateModel_ShouldValidate()
        {
            //Arrange
            UserModel testNotValid = new();
            UserModel testValid = new() { Username = "Aleks", Email = "aleks@domain.com", Password = "Bytmig123" };

            //Act
            var actualNotValid = _userService.ValidateModel(testNotValid);
            var actualValid = _userService.ValidateModel(testValid);

            //Assert
            Assert.False(actualNotValid);
            Assert.True(actualValid);
        }
    }
}
