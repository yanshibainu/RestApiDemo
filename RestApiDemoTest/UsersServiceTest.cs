using System;
using NSubstitute;
using NUnit.Framework;
using RestApiDemo.Model;
using RestApiDemo.Service;

namespace RestApiDemoTest
{
    public class UsersServiceTest
    {
        private UsersService _usersService;
        private JSONViewModel createData;
        private JSONViewModel editData;
        private IService<User, JSONViewModel> _IUsersService;
        [SetUp]
        public void Setup()
        {
            _IUsersService = Substitute.For<IService<User, JSONViewModel>>();
            //_usersService = new UsersService(_IUsersService);
            _usersService = new UsersService();
            createData = new JSONViewModel()
            {
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            };

            editData = new JSONViewModel()
            {
                Name = "DEF",
                Email = "123@123",
                Password = "123"
            };
            var user = _usersService.Create(createData);
            
        }

        [Test]
        public void CreateTest()
        {
            var user = _usersService.Create(createData);
            Assert.IsNotNull(user);
            Assert.AreEqual(createData.Email,user.Email);
            Assert.AreEqual(createData.Name, user.Name);
            Assert.AreEqual(createData.Password,user.Password);
        }

        [Test]
        public void AllTest()
        {
            var list = _usersService.All();
            Assert.IsNotNull(list);
        }

        [Test]
        public void EditTest()
        {
            var user = _usersService.Create(createData);
            var editUser = _usersService.Edit(user.Id, editData);
            Assert.IsNotNull(editUser);
            Assert.AreEqual(editUser.Name, editData.Name);
        }

        [Test]
        public void FindTest()
        {
            var user = _usersService.Create(createData);
            var findResult= _usersService.Find(user.Id);
            Assert.AreEqual(user, findResult);

        }

        [Test]
        public void DeleteTest()
        {
            var testID = Guid.NewGuid();
            Assert.//Throws<ArgumentException>(() => _usersService.Find(testID));
        }
        
    }
}