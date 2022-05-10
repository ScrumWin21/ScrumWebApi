using Microsoft.AspNetCore.Mvc;
using ScrumWin21WebAPI.BLL;
using ScrumWin21WebAPI.BLL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumWin21WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly BusinessLogicLayer _bll;
        public UsersController(BusinessLogicLayer bll) =>
            _bll = bll;

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<UserDisplayModel>> GetUsersAsync()
        {
            return new List<UserDisplayModel>();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
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
