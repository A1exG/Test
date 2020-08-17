using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGagarin.Test.Task.DataManager.Library.DataAccess;
using AGagarin.Test.Task.DataManager.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AGagarin.TestTask.DataManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserData _userData = new UserData();
        
        [Route("api/User/GetUsers")]
        [HttpGet]
        public List<UserModel> Get()
        {
            var output = _userData.GetAllUser();
            return output;
        }

        [Route("api/User/GetById")]
        [HttpGet]
        public UserModel GetById(int userId)
        {
            var output = _userData.GetUserById(userId);
            return output;
        }


        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public UserModel Get(int id)
        {
            var output = _userData.GetUserById(id);
            return output;
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
