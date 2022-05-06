﻿using Microsoft.AspNetCore.Mvc;
using ScrumWin21WebAPI.Models;
using ScrumWin21WebAPI.Models.DisplayModels;
using ScrumWin21WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumWin21WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<UserDisplayModel>> GetUsersAsync()
        {
            return await _userService.GetUsersAsync();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<UserDisplayModel> GetUserByIdAsync(int id)
        {
            return await _userService.GetUserByIdAsync(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
