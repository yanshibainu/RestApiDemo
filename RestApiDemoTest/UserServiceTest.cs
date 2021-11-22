using System;
using NUnit.Framework;
using RestApiDemo;
using RestApiDemo.Model;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDemoTest
{
    public class UsersServiceTest
    {
        private UsersService _usersService;
        private JSONViewModel createData;
        private User originalData;
        private JSONViewModel editData1;
        private JSONViewModel editData2;
        private JSONViewModel editData3;
        private IService<User, JSONViewModel> _IUsersService;
        private List<User> defaultList;
        private User AllTestData;
        [SetUp]
        public void Setup()
        {
            _IUsersService = Substitute.For<IService<User, JSONViewModel>>();
            _usersService = new UsersService();
            createData = new JSONViewModel()
            {
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            };
            originalData = new User()
            {
                Id = Guid.NewGuid(),
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            };
            editData1 = new JSONViewModel()
            {
                Name = "DEF",
                Email = null,
                Password = null
            };
            editData2 = new JSONViewModel()
            {
                Name = null,
                Email = "456@456",
                Password = null
            };
            editData3 = new JSONViewModel()
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
            /*var user = _usersService.Create(createData);
            Assert.IsNotNull(user);
            Assert.AreEqual(createData.Email, user.Email);
            Assert.AreEqual(createData.Name, user.Name);
            Assert.AreEqual(createData.Password, user.Password);-*/
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
            var editUser = _usersService.Edit(originalData.Id, editData1);
            Assert.IsNotNull(editUser);
            //Assert.AreEqual(editUser.Name, editData1.Name);

            /*editUser = _usersService.Edit(originalData.Id, editData2);
            Assert.IsNotNull(editUser);
            Assert.AreEqual(editUser.Name, editData1.Name);

            editUser = _usersService.Edit(originalData.Id, editData2);
            Assert.IsNotNull(editUser);
            Assert.AreEqual(editUser.Name, editData1.Name);*/
        }
        [Test]
        public void FindTest()
        {
            /*var user = _usersService.Create(createData);
            var findResult = _usersService.Find(user.Id);
            Assert.AreEqual(user, findResult);*/
        }
        [Test]
        public void DeleteTest()
        {
            var testID = Guid.NewGuid();
           /// Assert.//Throws<ArgumentException>(() => _usersService.Find(testID));
        }
    }
}