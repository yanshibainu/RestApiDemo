using System;
using NUnit.Framework;
using RestApiDemo;
using RestApiDemo.Model;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Service;
using Microsoft.EntityFrameworkCore;

using System.Text;

namespace RestApiDemoTest
{
    public class UsersServiceTest
    {
        private UsersService _usersService;
        private User createData;
        private UserViewModel editData1;
        private UserViewModel editData2;
        private UserViewModel editData3;
        private List<User> defaultList;
        private User AllTestData;
        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<UserDbContext>()
                .UseInMemoryDatabase(databaseName: "Products Test").Options;
            var context = new UserDbContext(option);
            _usersService = new UsersService(context);

            createData = new User()
            {
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            };
            editData1 = new UserViewModel()
            {
                Name = "DEF",
                Email = null,
                Password = null
            };
            editData2 = new UserViewModel()
            {
                Name = null,
                Email = "456@456",
                Password = null
            };
            editData3 = new UserViewModel()
            {
                Name = null,
                Email = null,
                Password = "456"
            };
            AllTestData = new User()
            {
                Id = Guid.NewGuid(),
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            };
            defaultList = new List<User>();
        }
        [Test]
        public void CreateTest()
        {
            var user = _usersService.Create(createData);
            Assert.IsNotNull(user);
            Assert.AreEqual(createData.Email, user.Email);
            Assert.AreEqual(createData.Name, user.Name);
            Assert.AreEqual(createData.Password, user.Password);
        }
        [Test]
        public void AllTest()
        {
            var list = _usersService.All();
            Assert.IsNotNull(list);
            defaultList.Add(AllTestData);
            User result = defaultList.First(t => t.Id == AllTestData.Id);
            Assert.AreEqual(result.Id, AllTestData.Id);
            Assert.AreEqual(result.Name, AllTestData.Name);
            Assert.AreEqual(result.Email, AllTestData.Email);
            Assert.AreEqual(result.Password, AllTestData.Password);
        }
        [Test]
        public void EditTest()
        {
            var user = _usersService.Create(createData);
            //name
            var editUser = _usersService.Edit(user.Id, editData1);
            Assert.IsNotNull(editUser);
            Assert.AreEqual(editUser.Name, editData1.Name);
            //email
            editUser = _usersService.Edit(user.Id, editData2);
            Assert.IsNotNull(editUser);
            Assert.AreEqual(editUser.Email, editData2.Email);
            //password
            editUser = _usersService.Edit(user.Id, editData3);
            Assert.IsNotNull(editUser);
            Assert.AreEqual(editUser.Password, editData3.Password);
        }
        [Test]
        public void FindTest()
        {
            var user = _usersService.Create(createData);
            var findResult = _usersService.Find(user.Id);
            Assert.AreEqual(user, findResult);
        }
        [Test]
        public void DeleteTest()
        {
            var user = _usersService.Create(createData);
            _usersService.Delete(user.Id);
            Assert.IsNull(_usersService.Find(user.Id));
        }
    }
}