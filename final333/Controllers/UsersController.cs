using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using final333.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final333.SERVICES;

namespace final333.MODEL
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _user;

        public UserController(UserService user)
        {
            _user = user;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<ICollection<User>> GetAlluser()
        {
            try
            {
                var user = _user.GetAllUsers();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _user.GetUserById(id);
                if (user == null)
                    return NotFound();

                return Ok(user);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // POST: api/User
        //[HttpPost]
        //public IActionResult CreateUser([FromBody] User user)
        //{
        //    try
        //    {
        //        if (user == null)
        //            return BadRequest("User object is null");

        //        _dbContext.user.Add(user);
        //        _dbContext.SaveChanges();
        //        return CreatedAtAction(nameof(GetUserById), new { id = user.customerid }, user);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

        // PUT: api/User/5
        //[HttpPut("{id}")]
        //public IActionResult UpdateUser(int id, [FromBody] User user)
        //{
        //    try
        //    {
        //        if (user == null || id != user.customerid)
        //            return BadRequest("Invalid user object");

        //        var existingUser = _dbContext.user.Find(id);
        //        if (existingUser == null)
        //            return NotFound();

        //        existingUser.name = user.name;
        //        existingUser.email = user.email;
        //        existingUser.password = user.password;

        //        _dbContext.SaveChanges();
        //        return NoContent();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

        // DELETE: api/User/5
        //[HttpDelete("{id}")]
        //public IActionResult DeleteUser(int id)
        //{
        //    try
        //    {
        //        var user = _dbContext.user.Find(id);
        //        if (user == null)
        //            return NotFound();

        //        _dbContext.user.Remove(user);
        //        _dbContext.SaveChanges();
        //        return NoContent();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500, "Internal server error");
        //    }
        //}
    }
}
