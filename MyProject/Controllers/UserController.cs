﻿using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;
using MyProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("MyProject/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //readonly UserService UserS = new UserService(); 
        readonly UserService _usersSerice;
        public UserController(UserService usersSerice)
        {
            _usersSerice = usersSerice;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _usersSerice.GetUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User u= _usersSerice.GetUserById(id);
            if (u == null)
                return NotFound(u);
            return u;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] User user)
        {
            return _usersSerice.AddUser(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] User user)
        {
            return _usersSerice.UpdateUser(id, user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _usersSerice.RemoveUser(id);
        }

        
    }
}
