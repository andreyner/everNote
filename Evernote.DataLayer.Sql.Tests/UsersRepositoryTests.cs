using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Evernote.DataLayer.Sql.Tests
{
    [TestClass]
    public class UsersRepositoryTests
    {
        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly List<Guid> _tempUsers = new List<Guid>();

        [TestMethod]
        public void ShouldCreateUser()
        {
            //arrange
            var user = new User
            {
                FirstName = "test",
                LastName = "test",
                Login = "ShouldCreateUser",
                Password= "ShouldCreateUser"
            };

            //act
            var repository = new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString));
            var result = repository.Create(user);

            _tempUsers.Add(user.Id);

            var userFromDb = repository.Get(result.Id);

            //asserts
            Assert.AreEqual(result.FirstName, userFromDb.FirstName);
        }

        [TestMethod]
        public void ShouldCreateUserAndAddCategory()
        {
            //arrange
            var user = new User
            {
                FirstName = "test",
                LastName = "test",
                Login= "ShouldCreateUserAndAddCategory",
                Password= "ShouldCreateUserAndAddCategory"
            };
            const string category = "testCategory";

            //act
            var categoriesRepository = new CategoriesRepository(ConnectionString);
            var usersRepository = new UsersRepository(ConnectionString, categoriesRepository);
            var notesRepository = new NotesRepository(usersRepository,ConnectionString);
            user = usersRepository.Create(user);

            _tempUsers.Add(user.Id);

            categoriesRepository.Create(user.Id, category);
            user = usersRepository.Get(user.Id);

            //asserts
            //Assert.AreEqual(category, user.Categories.Single().Name);
        }

        [TestCleanup]
        public void CleanData()
        {
            foreach (var id in _tempUsers)
                new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString)).Delete(id);
        }
    }
}
