using API.Controllers;
using API.DTOs;
using API.Interfaces;
using Controllers;
using Data;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        public DataContext _context;
        public ITokenService _tokenService;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void LoginTest()
        {
            AccountController abc = new AccountController(_context, _tokenService);
            LoginDto loginDto = new LoginDto()
            {
                Username = "vishal",
                Password = "password"
            };
            var user = abc.Login(loginDto);
            if (user != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void RegisterTest()
        {
            AccountController abc = new AccountController(_context, _tokenService);
            RegisterDto registerDto = new RegisterDto()
            {
                Username = "vishal",
                Password = "password"
            };
            var user = abc.Register(registerDto);
            if (user != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void GetUsersTest()
        {
            UsersController userController = new UsersController(_context);
            var users= userController.GetUsers();
            if (users != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
         [Test]
        public void GetUserTest()
        {
            UsersController userController = new UsersController(_context);
            var user= userController.GetUser(2);
            if (user != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}