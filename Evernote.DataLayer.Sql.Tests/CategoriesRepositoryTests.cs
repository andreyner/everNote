using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Evernote.DataLayer.Sql.Tests
{
    [TestClass]
    public class CategoriesRepositoryTests
    {
        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly List<Guid> _tempUsers = new List<Guid>();

        [TestMethod]
        public void ShouldCreateUserCreateCategoryaddNote()
        {
          //  arrange
            var user = new User
            {
                FirstName = "test",
                LastName = "test",
                Login = "login",
                Password = "password"
            };
            var userrepository = new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString));
            var result = userrepository.Create(user);

            _tempUsers.Add(user.Id);

            var userFromDb = userrepository.Get(result.Id);
            var categoriesRepository = new CategoriesRepository(ConnectionString);
            string categoryname = "testcategory";
            var creatcategory = categoriesRepository.Create(userFromDb.Id, categoryname);

            var noterepository = new NotesRepository(new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString)), ConnectionString);
            var note = new Note
            {
                header = "test",
                text = "test",
                Owner = userFromDb,
                Created = DateTime.Now,
                Changed = DateTime.Now
            };

            var noteresult = noterepository.Create(note);

            categoriesRepository.AddNoteintoCategory(noteresult.Id, creatcategory.Id);

            var resnotes=noterepository.GetNotesofCategory(creatcategory.Id);

            Assert.AreEqual(note.text,resnotes.Single().text);
        }

        [TestMethod]
        public void ShouldCreateUserCreateCategoryGetCategory()
        {
            var user = new User
            {
                FirstName = "test",
                LastName = "test",
                Login = "login",
                Password = "password"
            };
            var userrepository = new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString));
            var result = userrepository.Create(user);

            _tempUsers.Add(user.Id);

            var userFromDb = userrepository.Get(result.Id);
            var categoriesRepository = new CategoriesRepository(ConnectionString);
            string categoryname = "testcategory";
            var creatcategory = categoriesRepository.Create(userFromDb.Id, categoryname);
            var creatcategoryres= categoriesRepository.GetCategory(creatcategory.Id);

            Assert.AreEqual(creatcategory.Id, creatcategoryres.Id);



        }

        [TestMethod]
        public void ShouldCreateUserCreateCategoryaddNoteGetCategoryofNotes()
        {
            //  arrange
            var user = new User
            {
                FirstName = "test",
                LastName = "test",
                Login = "login",
                Password = "password"
            };
            var userrepository = new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString));
            var result = userrepository.Create(user);

            _tempUsers.Add(user.Id);

            var userFromDb = userrepository.Get(result.Id);
            var categoriesRepository = new CategoriesRepository(ConnectionString);
            string categoryname = "testcategory";
            var creatcategory = categoriesRepository.Create(userFromDb.Id, categoryname);

            var noterepository = new NotesRepository(new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString)), ConnectionString);
            var note = new Note
            {
                header = "test",
                text = "test",
                Owner = userFromDb,
                Created = DateTime.Now,
                Changed = DateTime.Now
            };

            var noteresult = noterepository.Create(note);

            categoriesRepository.AddNoteintoCategory(noteresult.Id, creatcategory.Id);

            var resnotes = noterepository.GetNotesofCategory(creatcategory.Id);
            var rescategoryofnote=categoriesRepository.GetNoteCategories(resnotes.Single().Id);
            Assert.AreEqual(creatcategory.Id, rescategoryofnote.Single().Id);

        }
        [TestCleanup]
        public void CleanData()
        {
            foreach (var id in _tempUsers)
                new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString)).Delete(id);
        }
    }
}
