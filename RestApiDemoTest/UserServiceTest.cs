using System;
using NUnit.Framework;
using RestApiDemo;
using RestApiDemo.Model;

namespace RestApiDemoTest
{
    public class UserServiceTest
    {
        private UsersService _usersService;
        
        [SetUp]
        public void Setup()
        {
            _usersService = new UsersService();
        }

        [Test]
        public void AddUserTest()
        {
            var user = _usersService.AddUser(new JSONViewModel()
            {

            });
            Assert.IsNotNull(user);
        }

        [Test]
        public void AddUserErrorTest()
        {
            Assert.Pass();
        }
    }
}