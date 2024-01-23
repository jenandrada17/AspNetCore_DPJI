using DPJI.API.Data;
using DPJI.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPJI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            return Ok(_context.TblUsers.ToArray());
        }

        [HttpGet("{email}")] 
        public ActionResult ValidateLogin(string email, string password)
        {
            var user = _context.TblUsers.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                if (user.Password == password)
                {
                    return Ok("Successfully Login!");
                }
                else
                {
                    return Unauthorized("Invalid credentials!"); // or return a different HTTP status code based on your application's logic
                } 
            }
            else
            {
                return NotFound(); // or return a different HTTP status code based on your application's logic
            }
        }


    }
}
