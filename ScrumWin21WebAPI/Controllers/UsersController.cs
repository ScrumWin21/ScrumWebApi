using Microsoft.AspNetCore.Mvc;
using ScrumWin21WebAPI.BLL;
using ScrumWin21WebAPI.BLL.Interfaces;
using ScrumWin21WebAPI.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumWin21WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBusinessLogicLayer _bll;
        public UsersController(IBusinessLogicLayer bll)
        {
            _bll = bll;
        }


        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<string> CreateUserAsync(UserModel newUser)
        {
            var success = await _bll.CreateAsync(newUser);
            return success.Item1;
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
