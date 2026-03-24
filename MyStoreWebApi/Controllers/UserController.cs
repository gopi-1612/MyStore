using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyStoreWebApi.Data;
using MyStoreWebApi.Models;
using MyStoreWebApi.Services;

namespace MyStoreWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly JwtService _jwtService;
        private readonly AppDbContext _context;
        public UserController(JwtService jwtService, AppDbContext context)
        {
            _jwtService = jwtService;
            _context = context;

        }

        [HttpPost("login")]
        public IActionResult Login(UserDTO userDto)
        {

            //verify password

            var userData = _context.users.FirstOrDefault(x => x.Email == userDto.Email);

            var hasher = new PasswordHasher<User>();

            if (userData != null)
            {
                var result = hasher.VerifyHashedPassword(
                           userData,
                           userData.PasswordHash,
                           userDto.Password);

                if (result != PasswordVerificationResult.Success)
                {
                    return Unauthorized("Invalid credentials");
                }

                Console.WriteLine("called user ............");
                var token = _jwtService.GenerateToken(userData.Email);
                return Ok(new { token });
            }
            else
            {
                return Ok("You have to signup first.....");

            }
        }

        [HttpPost("signUp/user")]
        public async Task<IActionResult> SignUp(UserDTO userDto)
        {
            User user = new User();

            user.FullName = userDto.FullName;
            user.Email = userDto.Email;
            user.Role = userDto.Role;
            user.Address = userDto.Address;
            user.PhoneNumber = userDto.PhoneNumber;
            user.CreatedAt = DateTime.Now;
            var hasher = new PasswordHasher<User>();
            user.PasswordHash = hasher.HashPassword(user, userDto.Password);

            _context.users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("Sign Up Seccessfully...");
        }
    }
}
